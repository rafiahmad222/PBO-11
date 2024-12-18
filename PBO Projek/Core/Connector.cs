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
        protected string addres = $"Host=localhost;Database=MekanikHunter;Username=postgres;Password=123";
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
        Nama_Kasir VARCHAR(100) NOT NULL
    );
    ");

            Execute_No_Return(@"
    CREATE TABLE IF NOT EXISTS Data_Teknisi(
        Id_Teknisi SERIAL PRIMARY KEY,
        Nama_Teknisi VARCHAR(100) NOT NULL
    );
    ");

            Execute_No_Return(@"
    CREATE TABLE IF NOT EXISTS Data_Layanan (
         Id_Layanan SERIAL PRIMARY KEY,
         Nama_Layanan VARCHAR(100) NOT NULL,
         Harga_Layanan DECIMAL(10, 2) NOT NULL
    );
    ");

            Execute_No_Return(@"
    CREATE TABLE IF NOT EXISTS Kategori_Suku_Cadang (
        Id_Kategori SERIAL PRIMARY KEY,
        Nama_Kategori VARCHAR(100) NOT NULL
    );
    ");

            Execute_No_Return(@"
    CREATE TABLE IF NOT EXISTS Data_Suku_Cadang (
         Id_Suku_Cadang SERIAL PRIMARY KEY,
         Nama_Suku_Cadang VARCHAR(100) NOT NULL,
         Id_Kategori INT NOT NULL,
         Stok INT NOT NULL,
         Harga DECIMAL(10, 2) NOT NULL,
         FOREIGN KEY (Id_Kategori) REFERENCES Kategori_Suku_Cadang(Id_Kategori)
    );
    ");

            Execute_No_Return(@"
CREATE TABLE IF NOT EXISTS Data_Servis (
    Id_Servis SERIAL PRIMARY KEY,
    Nama_Pemilik VARCHAR(100) NOT NULL,
    No_Kendaraan VARCHAR(20) NOT NULL,
    Id_Kasir INT NOT NULL,
    Total_Harga DECIMAL(18, 2) NOT NULL,
    Tanggal_Servis TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    CONSTRAINT FK_Kasir FOREIGN KEY (Id_Kasir)
        REFERENCES Data_Kasir(Id_Kasir) ON DELETE CASCADE
);



    ");

            Execute_No_Return(@"
CREATE TABLE IF NOT EXISTS Detail_Servis (
    Id_Detail_Servis SERIAL PRIMARY KEY,
    Id_Servis INT NOT NULL,
    Id_Teknisi INT,
    Id_Layanan INT,
    Id_Suku_Cadang INT,
    Jumlah INT NOT NULL,
    Harga DECIMAL(18, 2) NOT NULL,
    CONSTRAINT FK_Data_Servis FOREIGN KEY (Id_Servis)
        REFERENCES Data_Servis(Id_Servis) ON DELETE CASCADE,
    CONSTRAINT FK_Data_Teknisi FOREIGN KEY (Id_Teknisi)
        REFERENCES Data_Teknisi(Id_Teknisi) ON DELETE SET NULL,
    CONSTRAINT FK_Data_Layanan FOREIGN KEY (Id_Layanan)
        REFERENCES Data_Layanan(Id_Layanan) ON DELETE SET NULL,
    CONSTRAINT FK_Data_Suku_Cadang FOREIGN KEY (Id_Suku_Cadang)
        REFERENCES Data_Suku_Cadang(Id_Suku_Cadang) ON DELETE SET NULL
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
