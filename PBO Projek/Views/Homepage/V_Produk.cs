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
            dgvproduk();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void V_SukuCadang_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduk.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                FormTambahProduk kategori = new FormTambahProduk(csuca, false);
                kategori.labelid.Text = dgvProduk.Rows[e.RowIndex].Cells[1].Value.ToString();
                kategori.txtNamaProduk.Text = dgvProduk.Rows[e.RowIndex].Cells[2].Value.ToString();
                kategori.txtStok.Text = dgvProduk.Rows[e.RowIndex].Cells[4].Value.ToString();
                kategori.txtHargaProduk.Text = dgvProduk.Rows[e.RowIndex].Cells[5].Value.ToString();
                var kategoriList = csuca.GetDataKategori();
                foreach (var item in kategoriList)
                {
                    kategori.comboBox1.Items.Add(new { Text = item.Nama_Kategori, Value = item.Id_Kategori });
                }
                string selectedKategori = dgvProduk.Rows[e.RowIndex].Cells[3].Value.ToString();
                kategori.comboBox1.SelectedIndex = kategori.comboBox1.FindStringExact(selectedKategori);
                kategori.ShowDialog();
                dgvproduk();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTambahProduk produk = new FormTambahProduk(csuca, true);
            produk.ShowDialog();
            dgvproduk();
        }

        public void dgvproduk()
        {
            try
            {
                dgvProduk.Rows.Clear();
                var ProdukList = csuca.GetProduk();
                if (ProdukList != null && ProdukList.Count > 0)
                {
                    int no = 1;
                    foreach (var produk in ProdukList)
                    {
                        dgvProduk.Rows.Add(no++, produk.Id_Produk, produk.Nama_Produk, produk.Nama_Kategori, produk.Stok, produk.Harga);
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
                dgvProduk.Rows.Clear();
                DataTable dataTable = csuca.SearchProduk(textBox1.Text);
                foreach (DataRow row in dataTable.Rows)
                {
                    dgvProduk.Rows.Add(row["No"], row["Id_Suku_Cadang"], row["Nama_Suku_Cadang"], row["Nama_Kategori"], row["Stok"], row["Harga"]);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, title);
            }
        }
    }
}
