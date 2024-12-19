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
        private string connectionString = "Host=localhost;Database=PROJEK_KopMart;Username=postgres;Password=2";
        C_Homepage Controller;
        C_Alat ctrl;
        string title = "Kop-Mart";
        public V_AlatPertanian(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
            ctrl = new C_Alat(Controller, this);

        }

        private void V_TambahAlat_Load(object sender, EventArgs e)
        {
            dgvAlat();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TambahAlat tambahAlat = new TambahAlat(ctrl, false);
            tambahAlat.ShowDialog();
            dgvAlat();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT Id_Alat, Nama_Alat, Harga_Alat FROM Data_Alat WHERE Nama_Alat LIKE @searchText";
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
                    dgvriwayat.Rows.Clear();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        dgvriwayat.Rows.Add(row["No"], row["Id_Alat"], row["Nama_Alat"], row["Harga_Alat"]);
                    }
                }
            }
        }
        public void dgvAlat()
        {
            try
            {
                dgvriwayat.Rows.Clear();
                var alatlist = ctrl.GetDataAlat();
                if (alatlist != null && alatlist.Count > 0)
                {
                    int no = 1;
                    foreach (var alat in alatlist)
                    {
                        dgvriwayat.Rows.Add(no++, alat.Id_Alat, alat.Nama_Alat, alat.Harga_Alat);
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
            string colName = dgvriwayat.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                TambahAlat alat = new TambahAlat(ctrl, true);
                alat.lblid.Text = dgvriwayat.Rows[e.RowIndex].Cells[1].Value.ToString();
                alat.txtAlat.Text = dgvriwayat.Rows[e.RowIndex].Cells[2].Value.ToString();
                alat.txtHargaAlat.Text = dgvriwayat.Rows[e.RowIndex].Cells[3].Value.ToString();
                alat.ShowDialog();
                dgvAlat();

            }
        }
    }
}
