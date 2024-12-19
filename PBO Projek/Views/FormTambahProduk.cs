using PBO_Projek.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PBO_Projek.Views
{
    public partial class FormTambahProduk : Form
    {
        C_Produk Controller;
        private bool isEditing;
        System.String title = "Mekanik Hunter";
        bool cek = false;
        public FormTambahProduk(C_Produk controller, bool isEditing = false)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.isEditing = isEditing;
            Controller = controller;
            SetButtonStatus();
        }

        private void SetButtonStatus()
        {
            if (isEditing)
            {
                button3.Enabled = false; button2.Enabled = true;
            }
            else
            {
                button3.Enabled = true; button2.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormProduk_Load(object sender, EventArgs e)
        {
            var kategorilist = Controller.GetDataKategori();
            comboBox1.DataSource = kategorilist;
            comboBox1.DisplayMember = "Nama_Kategori";
            comboBox1.ValueMember = "Id_Kategori";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string namaProduk = txtNamaProduk.Text;
            int idKategori = (int)comboBox1.SelectedValue;
            int stok;
            decimal harga;
            bool stoknya = int.TryParse(txtStok.Text, out stok);
            bool harganya = decimal.TryParse(txtHargaProduk.Text, out harga);
            if (!stoknya)
            {
                MessageBox.Show("Stok harus berupa angka!", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!harganya)
            {
                MessageBox.Show("Harga harus berupa angka!", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            cekkosong();
            if (!cek) return;
            try
            {
                idKategori = (int)comboBox1.SelectedValue;

                if (MessageBox.Show("Apakah anda yakin ingin menambah?", "Tambah Produk", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Controller.AddProduk(namaProduk, idKategori, stok, harga);
                    MessageBox.Show("Data Produk Berhasil Ditambah", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    cek = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, title);
            }
        }

        public void Clear()
        {
            txtNamaProduk.Clear();
            txtHargaProduk.Clear();
            txtStok.Clear();

        }

        public void cekkosong()
        {
            cek = false;

            if (string.IsNullOrWhiteSpace(txtNamaProduk.Text) ||
                string.IsNullOrWhiteSpace(txtStok.Text) ||
                string.IsNullOrWhiteSpace(txtHargaProduk.Text) ||
                comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Isilah semua data, jangan ada yang kosong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cek = true;
        }

        private void txtHarSuk_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHarSuk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtStok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idProduk;
            string namaProduk = txtNamaProduk.Text;
            int idKategori = 0;
            int stok;
            decimal harga;
            try
            {
                if (string.IsNullOrWhiteSpace(labelid.Text) ||
                    string.IsNullOrWhiteSpace(txtNamaProduk.Text) ||
                    comboBox1.SelectedValue == null ||
                    string.IsNullOrWhiteSpace(txtStok.Text) ||
                    string.IsNullOrWhiteSpace(txtHargaProduk.Text))
                {
                    MessageBox.Show("Isilah semua data! Jangan ada yang kosong.", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (int.TryParse(labelid.Text, out idProduk))
                {
                    if (comboBox1.SelectedValue != null)
                    {
                        idKategori = Convert.ToInt32(comboBox1.SelectedValue);
                    }
                    else
                    {
                        MessageBox.Show("Kategori belum dipilih!", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!int.TryParse(txtStok.Text, out stok))
                    {
                        MessageBox.Show("Stok harus berupa angka!", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (!decimal.TryParse(txtHargaProduk.Text, out harga))
                    {
                        MessageBox.Show("Harga harus berupa angka!", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (MessageBox.Show("Apakah Anda yakin ingin mengedit?", "Edit Produk", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Controller.EditProduk(idProduk, namaProduk, idKategori, stok, harga);
                        MessageBox.Show("Data Produk berhasil diedit!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Clear();
                        this.Dispose();
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, title);
            }

        }
    }
}
