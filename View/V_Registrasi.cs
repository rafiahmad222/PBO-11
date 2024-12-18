using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBO_Projek.Controller;
using PBO_Projek.Model;
using PBO_Projek.Core;
namespace PBO_Projek.View
{
    public partial class V_Registrasi : Form
    {
        public V_Registrasi()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            RegisterAdmin(nama, email, username, password);
        }
        private void RegisterAdmin(string nama, string email, string username, string password)
        {
            if (nama == "" || email == "" || username == "" || password == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nama = txtNama.Text;
                email = txtEmail.Text;
                username = txtUsername.Text;
                password = txtPassword.Text;
                C_Login c_login = new C_Login();
                c_login.RegisterAdmin(nama, email, username, password);
                MessageBox.Show("Registrasi Berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
        
    }
}
