using Npgsql;
using PBO_Projek.Controller;
using PBO_Projek.Model;
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
    public partial class V_ManagementKasir : UserControl
    {
        C_Homepage Controller;
        C_ManagementKasir C_management;
        private string connectionString = "Host=localhost;Database=MekanikHunter;Username=postgres;Password=123";
        string title = "Mekanik Hunter";

        public V_ManagementKasir(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
            C_management = new C_ManagementKasir(Controller, this);

        }

        private void V_ManagementTeknisi_Load(object sender, EventArgs e)
        {
            dgvdatakasir();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormDataKasir kasir = new FormDataKasir(C_management, false);
            kasir.ShowDialog();
            dgvdatakasir();
        }

        public void dgvdatakasir()
        {
            try
            {
                dgvKasir.Rows.Clear();
                var kasirlist = C_management.GetDataKasir();
                if (kasirlist != null && kasirlist.Count > 0)
                {
                    int no = 1;
                    foreach (var kasir in kasirlist)
                    {
                        dgvKasir.Rows.Add(no++, kasir.Id_Kasir, kasir.Nama_Kasir, kasir.Username, kasir.Password );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvKasir.Rows.Clear();
                DataTable dataTable = C_management.SearchKasir(txtsKas.Text);
                foreach (DataRow row in dataTable.Rows)
                {
                    dgvKasir.Rows.Add(row["No"], row["Id_Kasir"], row["Nama_Kasir"], row["Username"], row["Password"]);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, title);
            }
        }

    private void dgvKasir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvKasir.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                FormDataKasir kasir = new FormDataKasir(C_management, true);
                kasir.lblEid.Text = dgvKasir.Rows[e.RowIndex].Cells[1].Value.ToString();
                kasir.txtNamaKas.Text = dgvKasir.Rows[e.RowIndex].Cells[2].Value.ToString();
                kasir.txtUserKas.Text = dgvKasir.Rows[e.RowIndex].Cells[3].Value.ToString();
                kasir.txtPassKas.Text = dgvKasir.Rows[e.RowIndex].Cells[4].Value.ToString();


                kasir.ShowDialog();
                dgvdatakasir();

            }
            else if (colName == "Hapus")
            {
                try
                {
                    if (MessageBox.Show("Yakin ingin menghapus ?", "Hapus Kasir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int idKasir = Convert.ToInt32(dgvKasir.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value);
                        string query = "DELETE FROM Data_Kasir WHERE Id_Kasir = @dataGridViewTextBoxColumn2";

                        using (var conn = new NpgsqlConnection(connectionString))
                        {
                            conn.Open();
                            using (var cmd = new NpgsqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@dataGridViewTextBoxColumn2", idKasir);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Data Kasir berhasil dihapus!", title);
                        dgvdatakasir();

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, title);
                }
            }
        }
    }
}
