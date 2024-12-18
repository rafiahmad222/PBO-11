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

namespace PBO_Projek.Views.Teknisi
{
    public partial class V_Transaksi : UserControl
    {
        C_Homepage Controller;
        C_Transaksi transaksi;
        private List<M_DetailTransaksi> servisDetails = new List<M_DetailTransaksi>();
        public V_Transaksi(C_Homepage controller)
        {
            InitializeComponent();
            Controller = controller;
            InitializeGrid();
            transaksi = new C_Transaksi(Controller, this);
        }

        private void V_LayananServis_Load(object sender, EventArgs e)
        {
            comboboxload();
            ResetForm();
            DataGridLoad();

        }

        private void comboboxload()
        {
            comboBox3.DataSource = transaksi.GetAllKasir();
            comboBox3.DisplayMember = "Nama_Kasir";
            comboBox3.ValueMember = "Id_Kasir";

            comboBox1.DataSource = transaksi.GetAllLayanan();
            comboBox1.DisplayMember = "Nama_Layanan";
            comboBox1.ValueMember = "Id_Layanan";

            comboBox2.DataSource = transaksi.GetAllSukuCadang();
            comboBox2.DisplayMember = "Nama_Suku_Cadang";
            comboBox2.ValueMember = "Id_Suku_Cadang";

        }

        private void DataGridLoad()
        {
            var layananlist = transaksi.GetAllLayanan();
            var sukucadanglist = transaksi.GetAllSukuCadang();


            foreach (var layanan in layananlist)
            {
                dataGridViewLayanan.Rows.Add(layanan.Nama_Layanan, layanan.Harga_Layanan);
            }
            foreach (var sukucadang in sukucadanglist)
            {
                dataGridViewSukuCadang.Rows.Add(sukucadang.Nama_Suku_Cadang, sukucadang.Harga);
            }

        }

        private void InitializeGrid()
        {
            dataGridViewPesanan.Columns.Clear();

            dataGridViewPesanan.Columns.Add("ID_Layanan", "ID Layanan");
            dataGridViewPesanan.Columns.Add("ID_SukuCadang", "ID Suku Cadang");

            dataGridViewPesanan.Columns["ID_Layanan"].Visible = false;
            dataGridViewPesanan.Columns["ID_SukuCadang"].Visible = false;

            dataGridViewPesanan.Columns.Add("NamaItem", "Nama Item");
            dataGridViewPesanan.Columns.Add("Jumlah", "Jumlah");
            dataGridViewPesanan.Columns.Add("Harga", "Harga");

            DataGridViewButtonColumn colHapus = new DataGridViewButtonColumn();
            colHapus.Name = "Hapus";
            colHapus.HeaderText = ""; 
            colHapus.Text = "X"; 
            colHapus.UseColumnTextForButtonValue = true;
            dataGridViewPesanan.Columns.Add(colHapus);


            dataGridViewPesanan.Columns["Harga"].ReadOnly = true;
            dataGridViewPesanan.AllowUserToAddRows = false;
        }



        private void TambahKeGrid(string namaItem, int jumlah, decimal hargaSatuan, bool isLayanan, int idLayanan = 0, int idSukuCadang = 0)
        {
            bool itemDitemukan = false;

            foreach (DataGridViewRow row in dataGridViewPesanan.Rows)
            {
                if (row.Cells["NamaItem"].Value?.ToString() == namaItem)
                {
                    itemDitemukan = true;

                    if (isLayanan)
                    {
                        MessageBox.Show("Layanan ini sudah dipilih!", "Duplikat Layanan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int jumlahSebelumnya = Convert.ToInt32(row.Cells["Jumlah"].Value);
                        row.Cells["Jumlah"].Value = jumlahSebelumnya + jumlah;
                        row.Cells["Harga"].Value = hargaSatuan * (jumlahSebelumnya + jumlah);
                    }
                    break;
                }
            }

            if (!itemDitemukan)
            {
                decimal hargaTotal = hargaSatuan * jumlah;
                dataGridViewPesanan.Rows.Add(idLayanan, idSukuCadang, namaItem, jumlah, hargaTotal);
            }

            HitungTotalHarga();
        }

        private bool ItemSudahAda(string namaItem)
        {
            foreach (DataGridViewRow row in dataGridViewPesanan.Rows)
            {
                if (row.Cells["NamaItem"].Value != null && row.Cells["NamaItem"].Value.ToString() == namaItem)
                {
                    return true;
                }
            }
            return false;
        }

        private decimal HitungTotalHarga()
        {
            decimal totalHarga = 0;

            foreach (DataGridViewRow row in dataGridViewPesanan.Rows)
            {
                if (row.Cells["Harga"].Value != null && row.Cells["Jumlah"].Value != null)
                {
                    decimal harga = Convert.ToDecimal(row.Cells["Harga"].Value);
                    int qty = Convert.ToInt32(row.Cells["Jumlah"].Value);

                    totalHarga += harga * qty;
                }
            }

            label10.Text = $"Total: {totalHarga:C}";

            return totalHarga; 
        }



        private void ResetForm()
        {
            textBox2.Clear();
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();

            comboBox3.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            label10.Text = "0";
            dataGridViewPesanan.Rows.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var selectedLayanan = (M_Alat)comboBox1.SelectedItem;
            if (selectedLayanan == null) return;

            string namaItem = selectedLayanan.Nama_Layanan;
            decimal harga = selectedLayanan.Harga_Layanan;
            int jumlah = 1;

            TambahKeGrid(selectedLayanan.Nama_Layanan, 1, selectedLayanan.Harga_Layanan, true, idLayanan: selectedLayanan.Id_Layanan);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var selectedSukuCadang = (M_Produk)comboBox2.SelectedItem;
            if (selectedSukuCadang == null) return;

            int jumlah;
            if (!int.TryParse(textBox3.Text, out jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Masukkan Jumlah Suku Cadang !!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TambahKeGrid(selectedSukuCadang.Nama_Suku_Cadang, jumlah, selectedSukuCadang.Harga, false, idSukuCadang: selectedSukuCadang.Id_Suku_Cadang);
        }

        private bool ValidasiStok(int idSukuCadang, int jumlah)
        {
            int stokTersedia = transaksi.GetStokSukuCadang(idSukuCadang);
            return stokTersedia >= jumlah;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi input
                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Nama Pemilik harus diisi!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Nomor Kendaraan harus diisi!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dataGridViewPesanan.Rows.Count == 0)
                {
                    MessageBox.Show("Tidak ada pesanan yang bisa diselesaikan!!!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox4.Text) || !decimal.TryParse(textBox4.Text, out decimal jumlahBayar))
                {
                    MessageBox.Show("Masukkan nominal bayar yang valid!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal totalHarga = HitungTotalHarga();

                if (jumlahBayar < totalHarga)
                {
                    MessageBox.Show("Jumlah bayar harus lebih besar atau sama dengan total harga!", "Pembayaran Kurang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal kembalian = jumlahBayar - totalHarga;

                M_Transaksi servisHeader = new M_Transaksi
                {
                    Nama_Pemilik = textBox2.Text.Trim(),
                    No_Kendaraan = textBox1.Text.Trim(),
                    Total_Harga = totalHarga,
                    Tanggal_Servis = DateTime.Now
                };

                if (comboBox3.SelectedValue == null || !int.TryParse(comboBox3.SelectedValue.ToString(), out int idTeknisi))
                {
                    MessageBox.Show("Teknisi harus dipilih!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                servisDetails.Clear();
                foreach (DataGridViewRow row in dataGridViewPesanan.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var detail = new M_DetailTransaksi
                        {
                            Id_Layanan = row.Cells["ID_Layanan"].Value != null ? Convert.ToInt32(row.Cells["ID_Layanan"].Value) : 0,
                            Id_Suku_Cadang = row.Cells["ID_SukuCadang"].Value != null ? Convert.ToInt32(row.Cells["ID_SukuCadang"].Value) : 0,
                            Id_Teknisi = idTeknisi, 
                            Jumlah = Convert.ToInt32(row.Cells["Jumlah"].Value),
                            Harga = Convert.ToDecimal(row.Cells["Harga"].Value)
                        };

                        if (detail.Id_Suku_Cadang != 0 && !ValidasiStok(detail.Id_Suku_Cadang, detail.Jumlah))
                        {
                            MessageBox.Show($"Stok tidak mencukupi untuk suku cadang dengan ID: {detail.Id_Suku_Cadang}",
                                            "Stok Tidak Cukup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        servisDetails.Add(detail);
                    }
                }

                transaksi.SimpanServis(servisHeader, servisDetails);
                MessageBox.Show($"Transaksi berhasil !!!\n\nTotal Harga: {totalHarga:C}\nJumlah Bayar: {jumlahBayar:C}\nKembalian: {kembalian:C}",
                                "Transaksi Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPesanan.Columns[e.ColumnIndex].Name == "Hapus" && e.RowIndex >= 0)
            {
                var result = MessageBox.Show("Apakah Anda yakin ingin menghapus item ini?",
                                             "Konfirmasi Hapus",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dataGridViewPesanan.Rows.RemoveAt(e.RowIndex);
                    HitungTotalHarga();
                }
            }
        }
    }
}
