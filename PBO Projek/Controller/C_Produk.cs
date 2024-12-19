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
        V_Produk viewProduk;

        public C_Produk(C_Homepage controller, V_Produk view)
        {
            Controller = controller;
            viewProduk = view;
        }

        private void ViewProduk_Click(object sender, EventArgs e)
        {
            viewProduk.button2.Visible = false;
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
        public List<M_Produk> GetProduk()
        {
            List<M_Produk> produkList = new List<M_Produk>();
            DataTable query = Execute_With_Return(@"
        SELECT p.Id_Produk, p.Nama_Produk, p.Stok, p.Harga, 
               p.Id_Kategori, k.Nama_Kategori
        FROM Data_Produk p
        LEFT JOIN Kategori_Produk k ON p.Id_Kategori = k.Id_Kategori");

            foreach (DataRow row in query.Rows)
            {
                M_Produk m_Produk = new M_Produk()
                {
                    Id_Produk = Convert.ToInt32(row["Id_Produk"]),
                    Nama_Produk = row["Nama_Produk"].ToString(),
                    Id_Kategori = Convert.ToInt32(row["Id_Kategori"]),
                    Nama_Kategori = row["Nama_Kategori"].ToString(),
                    Stok = Convert.ToInt32(row["Stok"]),
                    Harga = Convert.ToDecimal(row["Harga"]),
                };
                produkList.Add(m_Produk);
            }
            return produkList;
        }
        public void AddProduk(string namaProduk, int idKategori, int stok, decimal harga)
        {
            string query = @"INSERT INTO Data_Produk (Nama_Produk, Id_Kategori, Stok, Harga) VALUES (:Nama_Produk, :Id_Kategori, :Stok, :Harga);";
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue(":Nama_Produk", namaProduk);
                    cmd.Parameters.AddWithValue(":Id_Kategori", idKategori);
                    cmd.Parameters.AddWithValue(":stok", stok);
                    cmd.Parameters.AddWithValue(":harga", harga);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditProduk(int idProduk, string namaProduk, int idKategori, int stok, decimal harga)
        {
            string query = @"UPDATE Data_Produk SET Nama_Produk = :Nama_Produk, Id_Kategori = :Id_Kategori, Stok = :Stok, Harga = :Harga WHERE Id_Produk = :Id_Produk";
            using (var conn = new NpgsqlConnection(addres))
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query))
                {
                    cmd.Parameters.AddWithValue(":Id_Produk", idProduk);
                    cmd.Parameters.AddWithValue(":Nama_Produk", namaProduk);
                    cmd.Parameters.AddWithValue(":Id_Kategori", idKategori);
                    cmd.Parameters.AddWithValue(":Stok", stok);
                    cmd.Parameters.AddWithValue(":Harga", harga);
                    Execute_No_Return(cmd);
                }
            }
        }
        public DataTable SearchProduk(string searchText)
        {
            string query = @"
        SELECT 
            p.Id_Produk,
            p.Nama_Produk, 
            k.Nama_Kategori,
            p.Stok,
            p.Harga  
        FROM 
            Data_Produk p 
        JOIN  
            Kategori_Produk k 
        ON  
            p.Id_Kategori = k.Id_Kategori 
        WHERE  
            LOWER(p.Nama_Produk) LIKE LOWER(@SearchText) 
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
            DataTable query = Execute_With_Return("SELECT Id_Kategori, Nama_Kategori FROM Kategori_Produk");
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
            string query = @"INSERT INTO Kategori_Produk (Nama_Kategori) VALUES (:Nama_Kategori);";
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
