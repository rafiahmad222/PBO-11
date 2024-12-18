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
        V_AlatPertanian tambahLayanan;

        public C_Alat(C_Homepage controller, V_AlatPertanian view)
        {
            this.Controller = controller;
            this.tambahLayanan = view;
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

        public List<M_Alat> GetDataLayanan()
        {
            List<M_Alat> dtlayanan = new List<M_Alat>();
            DataTable query = Execute_With_Return("SELECT Id_Layanan, Nama_Layanan, Harga_Layanan FROM Data_Layanan");
            foreach (DataRow row in query.Rows)
            {
                M_Alat m_layanan = new M_Alat
                {
                    Id_Layanan = Convert.ToInt32(row["Id_Layanan"]),
                    Nama_Layanan = row["Nama_Layanan"].ToString(),
                    Harga_Layanan = Convert.ToDecimal(row["Harga_Layanan"])
                };
                dtlayanan.Add(m_layanan);
            }
            return dtlayanan;
        }

        public void addLayanan(string namaLayanan, decimal harlay)
        {
            string query = @" INSERT INTO Data_Layanan (Nama_Layanan, Harga_Layanan) VALUES (:Nama_Layanan, :Harga_Layanan); ";
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(":Nama_Layanan", namaLayanan);
                    cmd.Parameters.AddWithValue(":Harga_Layanan", harlay);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void editLayanan(int idlayanan, string namaLayanan, decimal harlay)
        {
            string query = @"UPDATE data_layanan SET Nama_Layanan = :Nama_Layanan, Harga_Layanan = :Harga_Layanan WHERE Id_Layanan = :Id_Layanan;";
            using (var conn = new NpgsqlConnection(addres))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query))
                {
                    cmd.Parameters.AddWithValue(":Id_Layanan", idlayanan);
                    cmd.Parameters.AddWithValue(":Nama_Layanan", namaLayanan);
                    cmd.Parameters.AddWithValue(":Harga_Layanan", harlay);
                    Execute_No_Return(cmd);
                }
            }
        }

        public DataTable SearchLayanan(string searchText)
        {
            string query = @"SELECT Id_Layanan, Nama_Layanan, Harga_Layanan WHERE Nama_Layanan LIKE @SearchText";
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
