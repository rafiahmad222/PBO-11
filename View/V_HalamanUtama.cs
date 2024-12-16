using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Npgsql;

namespace PBO_Projek.View
{
    public partial class V_HalamanUtama : Form
    {
        public V_HalamanUtama()
        {
            InitializeComponent();
            LoadPieChart();
        }

        private void LoadPieChart()
        {
            //chart1.ChartAreas[0].Area3DStyle.Enable3D = true; // Aktifkan 3D
            //chart1.ChartAreas[0].Area3DStyle.Inclination = 30; // Atur sudut tampilan
            //chart1.ChartAreas[0].Area3DStyle.Rotation = 45;   // Rotasi tampilan

            // Koneksi ke PostgreSQL
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=syil36;Database=kopmart";

            // Query untuk mengambil data dari tabel `keuangan`
            string query = "SELECT kategori, nilai FROM keuangan";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Ubah warna latar belakang keseluruhan chart
                    chart1.BackColor = Color.FromArgb(77, 113, 17); // Hijau tua sesuai gambar

                    // Ubah warna latar belakang ChartArea (area data)
                    chart1.ChartAreas[0].BackColor = Color.Transparent; // Buat transparan

                    chart1.Legends.Clear(); // Menghapus semua legenda



                    // Clear data sebelumnya di chart
                    chart1.Series.Clear();

                    // Tambahkan series untuk Pie Chart
                    //Series series = new Series("Keuangan");
                    //series.ChartType = SeriesChartType.Pie;
                    //chart1.Series.Add(series);

                    chart1.Series.Clear(); // Bersihkan data sebelumnya
                    Series series = new Series("Keuangan")
                    {
                        ChartType = SeriesChartType.Doughnut // Gunakan tipe Doughnut
                    };
                    chart1.Series.Add(series);

                    // Isi data ke chart
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string kategori = row["kategori"].ToString();
                        decimal nilai = Convert.ToDecimal(row["nilai"]);

                        series.Points.AddXY(kategori, nilai);
                    }

                    // Tambahkan label
                    series.Label = "#PERCENT{P0}"; // Menampilkan persentase
                    series.LegendText = "#AXISLABEL"; // Menampilkan nama kategori
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gabisa Woyy!" + ex.Message);
                }
            }
        }

        private void HalamanUtama_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
