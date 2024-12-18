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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PBO_Projek.Controller
{
    public class C_Produk : Connector
    {
        C_Homepage Controller;
        V_Produk viewsuca;

        public C_Produk(C_Homepage controller, V_Produk view)
        {
            Controller = controller;
            viewsuca = view;
        }

        private void Viewsuca_Click(object sender, EventArgs e)
        {
            viewsuca.button2.Visible = false;
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
        public List<M_Produk> GetSukuCadang()
        {
            List<M_Produk> sukuCadangList = new List<M_Produk>();
            DataTable query = Execute_With_Return(@"
        SELECT sc.Id_Suku_Cadang, sc.Nama_Suku_Cadang, sc.Stok, sc.Harga, 
               sc.Id_Kategori, kc.Nama_Kategori
        FROM Data_Suku_Cadang sc
        LEFT JOIN Kategori_Suku_Cadang kc ON sc.Id_Kategori = kc.Id_Kategori");

            foreach (DataRow row in query.Rows)
            {
                M_Produk m_SukuCadang = new M_Produk()
                {
                    Id_Suku_Cadang = Convert.ToInt32(row["Id_Suku_Cadang"]),
                    Nama_Suku_Cadang = row["Nama_Suku_Cadang"].ToString(),
                    Id_Kategori = Convert.ToInt32(row["Id_Kategori"]),
                    Nama_Kategori = row["Nama_Kategori"].ToString(),
                    Stok = Convert.ToInt32(row["Stok"]),
                    Harga = Convert.ToDecimal(row["Harga"]),

                };
                sukuCadangList.Add(m_SukuCadang);
            }
            return sukuCadangList;
        }
        public void AddSuCa(string namaSukuCadang, int idKategori, int stok, decimal harga)
        {
            string query = @"INSERT INTO Data_Suku_Cadang (Nama_Suku_Cadang,Id_Kategori, Stok, Harga) VALUES (:Nama_Suku_Cadang,:Id_Kategori, :Stok, :Harga);";
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(":Nama_Suku_Cadang", namaSukuCadang);
                    cmd.Parameters.AddWithValue(":Id_Kategori", idKategori);
                    cmd.Parameters.AddWithValue(":stok", stok);
                    cmd.Parameters.AddWithValue(":harga", harga);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void editSuCa(int idsukucadang, string namaSukuCadang, int idKategori, int stok, decimal harga)
        {
            string query = @"UPDATE Data_Suku_Cadang SET Nama_Suku_Cadang = :Nama_Suku_Cadang, Id_Kategori = :Id_Kategori, Stok = :Stok, Harga = :Harga WHERE Id_Suku_Cadang = :Id_Suku_Cadang";
            using (var conn = new NpgsqlConnection(addres))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query))
                {
                    cmd.Parameters.AddWithValue(":Id_Suku_Cadang", idsukucadang);
                    cmd.Parameters.AddWithValue(":Nama_Suku_Cadang", namaSukuCadang);
                    cmd.Parameters.AddWithValue(":Id_Kategori", idKategori);
                    cmd.Parameters.AddWithValue(":Stok", stok);
                    cmd.Parameters.AddWithValue(":Harga", harga);
                    Execute_No_Return(cmd);
                }
            }

        }
        public DataTable SearchSuCa(string searchText)
        {
        string query = @"
        SELECT 
            sc.Id_Suku_Cadang,
            sc.Nama_Suku_Cadang, 
            k.Nama_Kategori,
            sc.Stok,
            sc.Harga  
        FROM 
            Data_Suku_Cadang sc 
        JOIN  
            Kategori_Suku_Cadang k 
        ON  
            sc.Id_Kategori = k.Id_Kategori 
        WHERE  
            LOWER(sc.Nama_Suku_Cadang) LIKE LOWER(@SearchText) 
            OR LOWER(k.Nama_Kategori) LIKE LOWER(@SearchText)";
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



        public List<M_Kategori> GetDataKategori()
        {
            List<M_Kategori> dtkategori = new List<M_Kategori>();
            DataTable query = Execute_With_Return("SELECT Id_Kategori, Nama_Kategori FROM Kategori_Suku_Cadang");
            foreach (DataRow row in query.Rows)
            {
                M_Kategori m_Kategori = new M_Kategori
                {
                    Id_Kategori = Convert.ToInt32(row["Id_Kategori"]),
                    Nama_Kategori = row["Nama_Kategori"].ToString(),
                };
                dtkategori.Add(m_Kategori);
            }
            return dtkategori;
        }
        public void AddKategori(string namaKategori)
        {
            string query = @"INSERT INTO Kategori_Suku_Cadang (Nama_Kategori) VALUES (:Nama_Kategori);";
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(":Nama_Kategori", namaKategori);
                    cmd.ExecuteNonQuery();
                }
            }
        }



    }
}
