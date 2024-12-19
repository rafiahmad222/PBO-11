using Npgsql;
using PBO_Projek.Core;
using PBO_Projek.Model;
using PBO_Projek.Views.Homepage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PBO_Projek.Controller
{
    public class C_Alat : Connector
    {
        C_Homepage Controller;
        V_AlatPertanian tambahAlat;

        public C_Alat(C_Homepage controller, V_AlatPertanian view)
        {
            this.Controller = controller;
            this.tambahAlat = view;
        }
        public void Execute_No_Return(NpgsqlCommand cmd)
        {
            using (var conn = new NpgsqlConnection(addres))
            {
                cmd.Connection = conn;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<M_Alat> GetDataAlat()
        {
            List<M_Alat> dtalat = new List<M_Alat>();
            DataTable query = Execute_With_Return("SELECT Id_Layanan, Nama_Layanan, Harga_Layanan FROM Data_Layanan");
            foreach (DataRow row in query.Rows)
            {
                M_Alat m_alat = new M_Alat
                {
                    Id_Alat = Convert.ToInt32(row["Id_Alat"]),
                    Nama_Alat = row["Nama_Alat"].ToString(),
                    Harga_Alat = Convert.ToDecimal(row["Harga_Alat"])
                };
                dtalat.Add(m_alat);
            }
            return dtalat;
        }

        public void addAlat(string namaAlat, decimal hargaAlat)
        {
            string query = @" INSERT INTO Data_Layanan (Nama_Alat, Harga_Alat) VALUES (:Nama_Alat, :Harga_Alat); ";
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(":Nama_Alat", namaAlat);
                    cmd.Parameters.AddWithValue(":Harga_Alat", hargaAlat);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void editAlat(int idAlat, string namaAlat, decimal hargaAlat)
        {
            string query = @"UPDATE data_layanan SET Nama_Alat = :Nama_Alat, Harga_Alat = :Harga_Alat WHERE Id_Alat = :Id_Alat;";
            using (var conn = new NpgsqlConnection(addres))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query))
                {
                    cmd.Parameters.AddWithValue(":Id_Alat", idAlat);
                    cmd.Parameters.AddWithValue(":Nama_Alat", namaAlat);
                    cmd.Parameters.AddWithValue(":Harga_Alat", hargaAlat);
                    Execute_No_Return(cmd);
                }
            }
        }

        public DataTable SearchAlat(string searchText)
        {
            string query = @"SELECT Id_Alat, Nama_Alat, Harga_Alat FROM M_Alat WHERE Nama_Alat LIKE @SearchText";
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    DataTable dataTable = new DataTable();
                    dataTable.Load(cmd.ExecuteReader());
                    dataTable.Columns.Add("No", typeof(int));
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        dataTable.Rows[i]["No"] = i + 1;
                    }
                    return dataTable;
                }
            }
        }

    }

}
