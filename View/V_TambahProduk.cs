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
    public partial class V_TambahProduk : V_SampleAdd
    {
        string filePath;
        public V_TambahProduk()
        {
            InitializeComponent();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                filePath = opf.FileName;
                picturebox1.Image = new Bitmap(filePath);
            }
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtnamaproduk.Text == "" || txtHarga.Text == "" || txtStok.Text == "" || cbkategori.Text == "")
            {
                MessageBox.Show("Harap isi semua data");
            }
            else
            {
                // C_Product.InsertProduct(tbNamaProduk.Text, tbHargaProduk.Text, tbStokProduk.Text, tbDeskripsi.Text, filePath);
                MessageBox.Show("Produk berhasil ditambahkan");
                txtnamaproduk.Text = "";
                txtHarga.Text = "";
                txtStok.Text = "";

                picturebox1.Image = null;
            }
        }
        public override void btnBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public override void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtnamaproduk.Text == "" || txtHarga.Text == "" || txtStok.Text == "" || cbkategori.Text == "")
            {
                MessageBox.Show("Harap isi semua data");
            }
            else
            {
                C_Product.InsertProduct(txtnamaproduk.Text, txtHarga.Text, txtStok.Text, cbkategori.Text, filePath);
                MessageBox.Show("Produk berhasil ditambahkan");
                txtnamaproduk.Text = "";
                txtHarga.Text = "";
                txtStok.Text = "";

                picturebox1.Image = null;
            }
        }
    }
}
