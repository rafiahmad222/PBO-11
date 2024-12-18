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

namespace PBO_Projek.Views.Homepage
{
    public partial class V_RiwayatTransaksi : UserControl
    {
        C_Homepage Controller;
        C_RiwayatTransaksi RiwayatTransaksi;
        public V_RiwayatTransaksi(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
            RiwayatTransaksi = new C_RiwayatTransaksi(controller, this);
        }

        private void V_RiwayatTransaksi_Load(object sender, EventArgs e)
        {
            RiwayatTransaksi.LoadRiwayatTransaksi();
        }

        private void dgvLay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLay.Columns[e.ColumnIndex].Name == "Detail")
            {
                int idServis = Convert.ToInt32(dgvLay.Rows[e.RowIndex].Cells["Column2"].Value);

                FormDetailTransaksi detailForm = new FormDetailTransaksi(RiwayatTransaksi);
                detailForm.LoadDetailServis(idServis);
                detailForm.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvLay.Rows.Clear();
                DataTable dataTable = RiwayatTransaksi.SearchRiwayatTransaksi(textBox1.Text);

                foreach (DataRow row in dataTable.Rows)
                {
                    dgvLay.Rows.Add(
                        row["No"],
                        row["Id_Servis"],
                        row["Nama_Pemilik"],
                        row["No_Kendaraan"],
                        row["Nama_Kasir"],
                        Convert.ToDateTime(row["Tanggal_Servis"]).ToString("dd/MM/yyyy"),
                        row["Total_Harga"].ToString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
