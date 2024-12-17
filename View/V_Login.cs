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


namespace PBO_Projek.View
{
    public partial class V_Login : Form
    {
        public static string? username { get; internal set; }
        public static string? password { get; internal set; }
        public V_Login()
        {
            InitializeComponent();
        }

        private void btnMaxim_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (C_Login.login(txtUsername.Text, txtPass.Text))
            {
                V_HalamanUtama halamanUtama = new V_HalamanUtama();
                halamanUtama.Show();
                this.Hide();
            }
        }

        private void btnRegistrasi_Click(object sender, EventArgs e)
        {
            V_Registrasi registrasi = new V_Registrasi();
            registrasi.Show();
            this.Hide();
        }
    }
}
