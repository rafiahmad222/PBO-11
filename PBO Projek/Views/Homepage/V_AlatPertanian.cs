using Npgsql;
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
    public partial class V_AlatPertanian : UserControl
    {
        private string connectionString = "Host=localhost;Database=MekanikHunter;Username=postgres;Password=123";
        C_Homepage Controller;
        C_Alat ctrl;
        string title = "Mekanik Hunter";
        public V_AlatPertanian(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
            ctrl = new C_Alat(Controller, this);

        }

        private void V_TambahLayanan_Load(object sender, EventArgs e)
        {
            dgvlayanan();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TambahAlat tambahLayanan = new TambahAlat(ctrl, false);
            tambahLayanan.ShowDialog();
            dgvlayanan();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT Id_Layanan, Nama_Layanan, Harga_Layanan FROM Data_Layanan WHERE Nama_Layanan LIKE @searchText";
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open(); using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@searchText", "%" + textBox1.Text + "%");
                    DataTable dataTable = new DataTable();
                    dataTable.Load(cmd.ExecuteReader());
                    dataTable.Columns.Add("No", typeof(int));
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        dataTable.Rows[i]["No"] = i + 1;
                    }
                    dgvLay.Rows.Clear();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        dgvLay.Rows.Add(row["No"], row["Id_Layanan"], row["Nama_Layanan"], row["Harga_Layanan"]);
                    }
                }
            }
        }
        public void dgvlayanan()
        {
            try
            {
                dgvLay.Rows.Clear();
                var layananlist = ctrl.GetDataLayanan();
                if (layananlist != null && layananlist.Count > 0)
                {
                    int no = 1;
                    foreach (var layanan in layananlist)
                    {
                        dgvLay.Rows.Add(no++, layanan.Id_Layanan, layanan.Nama_Layanan, layanan.Harga_Layanan);
                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, title);
            }
        }

        private void dgvLay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvLay.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                TambahAlat layanan = new TambahAlat(ctrl, true);
                layanan.lblid.Text = dgvLay.Rows[e.RowIndex].Cells[1].Value.ToString();
                layanan.txtAlat.Text = dgvLay.Rows[e.RowIndex].Cells[2].Value.ToString();
                layanan.txtHargaAlat.Text = dgvLay.Rows[e.RowIndex].Cells[3].Value.ToString();
                layanan.ShowDialog();
                dgvlayanan();

            }
        }
    }
}
