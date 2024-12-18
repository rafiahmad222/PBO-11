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
    public partial class FormDetailTransaksi : Form
    {
        C_RiwayatTransaksi Controller;
        public FormDetailTransaksi(C_RiwayatTransaksi controller)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Controller = controller;
        }

        public void LoadDetailServis(int idServis)
        {
            Controller.LoadDetailServis(idServis, dgvDetail);
        }

        private void dgvLay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
