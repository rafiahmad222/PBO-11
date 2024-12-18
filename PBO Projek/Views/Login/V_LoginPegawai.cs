using PBO_Projek.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBO_Projek.Views
{
    public partial class V_LoginOwner : UserControl
    {
        C_MainFrame Controller;
        public V_LoginOwner(C_MainFrame controller)
        {
            InitializeComponent();
            Controller = controller;
            textPassword.PasswordChar = '*';
        }

        private void V_LoginOwner_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textPassword.PasswordChar = '\0';
            }
            else
            {
                textPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller.v_awal = new V_awal(Controller);
            Controller.SwitchView(Controller.v_awal);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = textPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Controller.LoginKasir(username, password);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
