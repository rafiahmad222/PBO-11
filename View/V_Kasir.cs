using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Projek.View
{
    public partial class V_Kasir : Form
    {
        public V_Kasir()
        {
            InitializeComponent();
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMxms_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void btnRst_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            V_HalamanUtama halamanUtama = new V_HalamanUtama();
            halamanUtama.Show();
            this.Hide();
        }

        private void btnMnms_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void V_Kasir_Load(object sender, EventArgs e)
        {

        }
    }
}
