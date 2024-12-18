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
    public partial class V_Produk : UserControl
    {
        C_Homepage Controller;
        C_Produk csuca;
        M_Kasir kasir = new M_Kasir();
        string title = "Mekanik Hunter";

        public V_Produk(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
            csuca = new C_Produk(Controller, this);
            dgvsukucadang();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void V_SukuCadang_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvSukuCadang.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                FormSukuCadang kategori = new FormSukuCadang(csuca, false);
                kategori.labelid.Text = dgvSukuCadang.Rows[e.RowIndex].Cells[1].Value.ToString();
                kategori.txtSuku.Text = dgvSukuCadang.Rows[e.RowIndex].Cells[2].Value.ToString();
                kategori.txtStok.Text = dgvSukuCadang.Rows[e.RowIndex].Cells[4].Value.ToString();
                kategori.txtHarSuk.Text = dgvSukuCadang.Rows[e.RowIndex].Cells[5].Value.ToString();
                var kategoriList = csuca.GetDataKategori();
                foreach (var item in kategoriList)
                {
                    kategori.comboBox1.Items.Add(new { Text = item.Nama_Kategori, Value = item.Id_Kategori });
                }
                string selectedKategori = dgvSukuCadang.Rows[e.RowIndex].Cells[3].Value.ToString();
                kategori.comboBox1.SelectedIndex = kategori.comboBox1.FindStringExact(selectedKategori);
                kategori.ShowDialog();
                dgvsukucadang();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSukuCadang sukuCadang = new FormSukuCadang(csuca, true);
            sukuCadang.ShowDialog();
            dgvsukucadang();
        }

        public void dgvsukucadang()
        {
            try
            {
                dgvSukuCadang.Rows.Clear();
                var sukuCadangList = csuca.GetSukuCadang();
                if (sukuCadangList != null && sukuCadangList.Count > 0)
                {
                    int no = 1;
                    foreach (var sukuCadang in sukuCadangList)
                    {
                        dgvSukuCadang.Rows.Add(no++, sukuCadang.Id_Suku_Cadang, sukuCadang.Nama_Suku_Cadang, sukuCadang.Nama_Kategori, sukuCadang.Stok, sukuCadang.Harga);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, title);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTambahKategori kategori = new FormTambahKategori(csuca);
            kategori.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvSukuCadang.Rows.Clear();
                DataTable dataTable = csuca.SearchSuCa(textBox1.Text);
                foreach (DataRow row in dataTable.Rows)
                {
                    dgvSukuCadang.Rows.Add(row["No"], row["Id_Suku_Cadang"], row["Nama_Suku_Cadang"], row["Nama_Kategori"], row["Stok"], row["Harga"]);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, title);
            }
        }
    }
}
