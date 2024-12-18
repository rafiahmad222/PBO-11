using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PBO_Projek.Controller;
using PBO_Projek.Model;

namespace PBO_Projek.View
{
    public partial class V_MainForm : Form
    {
        public V_MainForm()
        {
            InitializeComponent();

        }
        private void HalamanUtama_Load(object sender, EventArgs e)
        {
            labelAdmin.Text = C_Login.LoginAdminNama;
        }
        public void AddFormInPanel(Form fh)
        {
            CenterPanel.Controls.Clear();
            fh.Dock = DockStyle.Fill;
            fh.TopLevel = false;
            CenterPanel.Controls.Add(fh);
            fh.Show();
        }
        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new V_Beranda());
        }


    }
}
