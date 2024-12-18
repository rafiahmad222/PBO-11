using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using PBO_Projek.Model;
using PBO_Projek.Core;
using System.Data;
using System.Windows.Forms;
using PBO_Projek.View;
using System.Runtime.InteropServices.Marshalling;


namespace PBO_Projek.Controller
{
    public class C_Login : dataConnection
    {
        public static string LoginAdminNama { get; private set; }
        public static bool login(string username, string password)
        {
            try
            {
                string query = "SELECT * FROM akun WHERE username = @username AND password = @password";
                NpgsqlParameter[] parameters =
                {
                    new NpgsqlParameter("@username", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = username},
                    new NpgsqlParameter("@password", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = password}
                };
                var result = dataConnection.queryExecutor(query, parameters);
                if (result.Rows.Count > 0)
                {
                    LoginAdminNama = result.Rows[0]["nama"].ToString();
                    MessageBox.Show("Login Berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    V_MainForm halamanUtama = new V_MainForm();
                    halamanUtama.Show();
                    return true;
                }
                MessageBox.Show("Login Gagal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public bool RegisterAdmin(string nama, string email, string username, string password)
        {
            // Validate input data
            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Semua field harus diisi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                string query = "INSERT INTO akun (nama, email, username, password) VALUES (@nama, @email, @username, @password)";
                NpgsqlParameter[] parameters =
                {
                    new NpgsqlParameter("@nama", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = nama},
                    new NpgsqlParameter("@email", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = email},
                    new NpgsqlParameter("@username", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = username},
                    new NpgsqlParameter("@password", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = password}
                };
                var result = dataConnection.queryExecutor(query, parameters);
                if (result.Rows.Count > 0)
                {
                    MessageBox.Show("Registrasi Berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Registrasi Gagal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
