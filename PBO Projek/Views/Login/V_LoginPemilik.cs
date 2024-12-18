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

namespace PBO_Projek.Views
{
    public partial class V_LoginPemilik : UserControl
    {
        C_MainFrame Controller;
        public V_LoginPemilik(C_MainFrame controller)
        {
            InitializeComponent();
            Controller = controller;
            textPassword.PasswordChar = '*';
        }

        private void V_LoginPemilik_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controller.v_awal = new V_awal(Controller);
            Controller.SwitchView(Controller.v_awal);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textPassword.PasswordChar = '\0';
            }

            else { textPassword.PasswordChar = '*'; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.login();
        }
    }
}
