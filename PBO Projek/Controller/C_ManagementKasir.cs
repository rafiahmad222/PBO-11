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

namespace PBO_Projek.Controller
{
    public class C_ManagementKasir : Connector
    {
        C_Homepage Controller;
        V_ManagementKasir vmanagement;

        public C_ManagementKasir(C_Homepage controller, V_ManagementKasir view)
        {
            Controller = controller;
            vmanagement = view;
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
        public List<M_Kasir> GetDataKasir()
        {
            List<M_Kasir> dtkasir = new List<M_Kasir>();
            DataTable query = Execute_With_Return("SELECT Id_Kasir, Nama_Kasir, Username, Password FROM Data_Kasir");

            foreach (DataRow row in query.Rows)
            {
                M_Kasir m_Kasir = new M_Kasir
                {
                    Id_Kasir = Convert.ToInt32(row["Id_Kasir"]),
                    Nama_Kasir = row["Nama_Kasir"].ToString(),
                    Username = row["Username"].ToString(),
                    Password = row["Password"].ToString(),
                };
                dtkasir.Add(m_Kasir);
            }
            return dtkasir;
        }

        public void AddKasir(string namaKasir, string username, string password)
        {
            string query = "INSERT INTO Data_Kasir (Nama_Kasir, Username, Password) VALUES (@NamaKasir, @Username, @Password);";
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NamaKasir", namaKasir);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteKasir(int idKasir)
        {
            string query = "DELETE FROM Data_Kasir WHERE Id_Kasir = @Id_Kasir;";
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_Kasir", idKasir);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditKasir(int idKasir, string namaKasir, string username, string password)
        {
            string query = "UPDATE Data_Kasir SET Nama_Kasir = @NamaKasir, Username = @Username, Password = @Password WHERE Id_Kasir = @Id_Kasir;";
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id_Kasir", idKasir);
                    cmd.Parameters.AddWithValue("@NamaKasir", namaKasir);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable SearchKasir(string searchText)
        {
            string query = "SELECT Id_Kasir, Nama_Kasir, Username, Password FROM Data_Kasir WHERE Nama_Kasir LIKE @SearchText;";
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
