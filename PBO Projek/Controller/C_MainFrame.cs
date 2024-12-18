using Npgsql;
using PBO_Projek.Core;
using PBO_Projek.Model;
using PBO_Projek.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Projek.Controller
{
    public class C_MainFrame : Connector
    {
        C_MainFrame Controller;
        public MainFrame v_mainFrame;
        public V_awal v_awal;
        public V_LoginOwner v_LoginOwner;
        public V_LoginPemilik v_LoginPemilik;
        public C_MainFrame(MainFrame mainFrame)
        {
            this.v_mainFrame = mainFrame;
            v_awal = new V_awal(this);
            v_LoginOwner = new V_LoginOwner(this);
            v_LoginPemilik = new V_LoginPemilik(this);
            SwitchView(v_awal);
            setup();
        }
        public void SwitchView(UserControl view)
        {
            v_mainFrame.panel1.Controls.Clear();
            v_mainFrame.panel1.Controls.Add(view);
        }
        public void login()
        {
            if (v_LoginPemilik.Username.Text == "admin" || v_LoginPemilik.textPassword.Text == "admin")
            {
                HomepageOwner homepageOwner = new HomepageOwner();
                v_mainFrame.Hide();
                homepageOwner.ShowDialog();
                v_mainFrame.Close();
            }
        }

        public M_Kasir GetKasirByUsername(string username)
        {
            string query = "SELECT Id_Kasir, Nama_Kasir, Username, Password FROM Data_Kasir WHERE Username = @Username;";
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            M_Kasir.Id = reader.GetInt32(reader.GetOrdinal("Id_Kasir"));
                            return new M_Kasir
                            {
                                Id_Kasir = reader.GetInt32(reader.GetOrdinal("Id_Kasir")),
                                Nama_Kasir = reader.GetString(reader.GetOrdinal("Nama_Kasir")),
                                Username = reader.GetString(reader.GetOrdinal("Username")),
                                Password = reader.GetString(reader.GetOrdinal("Password"))
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void LoginKasir(string username, string password)
        {
            M_Kasir kasir = GetKasirByUsername(username);
            if (kasir != null && kasir.Password == password)
            {
                M_Kasir.Id = kasir.Id_Kasir;
                MessageBox.Show($"Selamat datang, {kasir.Nama_Kasir}!", "Login Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomepageKasir homepageKasir = new HomepageKasir();
                v_mainFrame.Hide();
                homepageKasir.ShowDialog();
                v_mainFrame.Close();
            }
            else
            {
                MessageBox.Show("Login gagal! Username atau password salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
