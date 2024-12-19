using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PBO_Projek.Core
{
    public abstract class Connector
    {
        protected string addres = $"Host=localhost;Database=PROJEK_KopMart;Username=postgres;Password=2";
        private NpgsqlConnection Conn;
        protected NpgsqlConnection conn
        {
            get
            {
                return this.Conn;
            }
            set
            {
                if (Conn != null)
                {
                    Conn.Close();
                    Conn.Dispose();
                    Conn = null;
                }
                Conn = value;
                Conn.Open();
            }
        }
        public void setup()
        {
            Execute_No_Return(@"
            CREATE TABLE IF NOT EXISTS Data_Kasir (
                Id_Kasir SERIAL PRIMARY KEY,
                Username VARCHAR(50) NOT NULL,
                Password VARCHAR(50) NOT NULL,
                Nama_Kasir VARCHAR(100) NOT NULL);
                ");
            Execute_No_Return(@"
            CREATE TABLE IF NOT EXISTS Data_AlatPertanian (
                Id_Alat SERIAL PRIMARY KEY,
                Nama_Alat VARCHAR(100) NOT NULL,
                Harga_Alat DECIMAL(10, 2) NOT NULL
            );
                ");

            Execute_No_Return(@"
            CREATE TABLE IF NOT EXISTS Kategori_Produk (
                Id_Kategori SERIAL PRIMARY KEY,
                Nama_Kategori VARCHAR(100) NOT NULL
            );
                ");

            Execute_No_Return(@"
            CREATE TABLE IF NOT EXISTS Data_Produk (
                Id_Produk SERIAL PRIMARY KEY,
                Nama_Produk VARCHAR(100) NOT NULL,
                Id_Kategori INT NOT NULL,
                Stok INT NOT NULL,
                Harga DECIMAL(10, 2) NOT NULL,
                CONSTRAINT FK_KategoriProduk FOREIGN KEY (Id_Kategori)
                    REFERENCES KategoriProduk(Id_Kategori) ON DELETE CASCADE
            );
                ");

            Execute_No_Return(@"
            CREATE TABLE IF NOT EXISTS Data_Transaksi (
                Id_Transaksi SERIAL PRIMARY KEY,
                Nama_Pembeli VARCHAR(100) NOT NULL,
                Kode_Penjualan VARCHAR(20) NOT NULL,
                Id_Kasir INT NOT NULL,
                Total_Harga DECIMAL(18, 2) NOT NULL,
                Tanggal_Transaksi TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                CONSTRAINT FK_Kasir FOREIGN KEY (Id_Kasir)
                    REFERENCES Data_Kasir(Id_Kasir) ON DELETE CASCADE
            );
                ");

            Execute_No_Return(@"
            CREATE TABLE IF NOT EXISTS Detail_Transaksi (
                Id_Detail_Transaksi SERIAL PRIMARY KEY,
                Id_Transaksi INT NOT NULL,
                Id_Kasir INT,
                Id_Alat INT,
                Id_Produk INT,
                Jumlah INT NOT NULL,
                Harga DECIMAL(18, 2) NOT NULL,
                CONSTRAINT FK_DataTransaksi FOREIGN KEY (Id_Transaksi)
                    REFERENCES DataTransaksi(Id_Transaksi) ON DELETE CASCADE,
                CONSTRAINT FK_DataKasir FOREIGN KEY (Id_Kasir)
                    REFERENCES Data_Kasir(Id_Kasir) ON DELETE SET NULL,
                CONSTRAINT FK_Data_AlatPertanian FOREIGN KEY (Id_Alat)
                    REFERENCES Data_AlatPertanian(Id_Alat) ON DELETE SET NULL,
                CONSTRAINT FK_Dataroduk FOREIGN KEY (Id_Produk)
                    REFERENCES Dataroduk(Id_Produk) ON DELETE SET NULL
            );
                ");
        }

        public void Execute_No_Return(string query)
        { 
            using (var conn = new NpgsqlConnection(addres)) 
            { 
                conn.Open(); using (var cmd = new NpgsqlCommand(query, conn)) 
                { 
                    cmd.ExecuteNonQuery(); 
                } 
            } 
        }
        public DataTable Execute_With_Return(string query) 
        {
            using (var conn = new NpgsqlConnection(addres)) 
            {
                conn.Open(); using (var cmd = new NpgsqlCommand(query, conn)) 
                {
                    DataTable data = new DataTable();
                    data.Load(cmd.ExecuteReader());
                    return data; 
                }
            } 
        }

        public DataTable Execute_With_Return(NpgsqlCommand query) 
        {
            using (var conn = new NpgsqlConnection(addres)) 
            {
                conn.Open(); 
                query.Connection = conn; 
                DataTable data = new DataTable(); 
                data.Load(query.ExecuteReader());
                return data; 
            } 
        }
    }
}
