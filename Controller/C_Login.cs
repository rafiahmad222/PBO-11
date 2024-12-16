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


namespace PBO_Projek.Controller
{
    public class C_Login : dataConnection
    {
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
                    MessageBox.Show("Login Berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    V_HalamanUtama halamanUtama = new V_HalamanUtama();
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
        public static bool register(M_Akun akun)
        {
            try
            {
                string query = "INSERT INTO akun (nama, email, password, username) VALUES (@nama, @email, @password, @username)";
                NpgsqlParameter[] parameters =
                {
                    new NpgsqlParameter("@nama", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = akun.nama},
                    new NpgsqlParameter("@email", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = akun.email},
                    new NpgsqlParameter("@password", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = akun.password},
                    new NpgsqlParameter("@username", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = akun.username}
                };
                dataConnection.commandExecutor(query, parameters);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
