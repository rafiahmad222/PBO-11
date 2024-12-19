using Npgsql;
using PBO_Projek.Core;
using PBO_Projek.Model;
using PBO_Projek.Views.Homepage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Projek.Controller
{
    public class C_RiwayatTransaksi : Connector
    {
        C_Homepage Controller;
        V_RiwayatTransaksi Riwayat;

        public C_RiwayatTransaksi(C_Homepage controller, V_RiwayatTransaksi riwayat)
        {
            Controller = controller;
            Riwayat = riwayat;
        }

        public List<M_Transaksi> GetRiwayatTransaksi()
        {
            var riwayatList = new List<M_Transaksi>();

            using (var conn = new NpgsqlConnection(addres))
            {
                string query = @"
                SELECT dt.Id_Transaksi, dt.Nama_Pemilik, dt.No_Kendaraan, 
                    dt.Id_Kasir, k.Nama_Kasir, 
                    dt.Total_Harga, dt.Tanggal_Transaksi
                FROM Data_Transaksi dt
                LEFT JOIN Data_Kasir k ON dt.Id_Kasir = k.Id_Kasir  
                ORDER BY dt.Tanggal_Transaksi DESC";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                riwayatList.Add(new M_Transaksi
                                {
                                    Id_Transaksi = reader.GetInt32(reader.GetOrdinal("Id_Transaksi")),
                                    Nama_Pembeli = reader.GetString(reader.GetOrdinal("Nama_Pemilik")),
                                    Kode_Penjualan = reader.GetString(reader.GetOrdinal("No_Kendaraan")),
                                    Id_Kasir = reader.GetInt32(reader.GetOrdinal("Id_Kasir")),
                                    Total_Harga = reader.GetDecimal(reader.GetOrdinal("Total_Harga")),
                                    Tanggal_Transaksi = reader.GetDateTime(reader.GetOrdinal("Tanggal_Transaksi"))
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        throw;
                    }
                }
            }

            return riwayatList;
        }

        public List<M_DetailTransaksi> GetDetailTransaksi(int idTransaksi)
        {
            var detailList = new List<M_DetailTransaksi>();

            using (var conn = new NpgsqlConnection(addres))
            {
                string query = @"
                SELECT dt.Id_Detail_Transaksi, dt.Id_Transaksi, dt.Id_Layanan, dt.Id_Produk, 
                    dt.Jumlah, dt.Harga, dt.Id_Teknisi, t.Nama_Teknisi, p.Nama_Produk
                FROM Detail_Transaksi dt
                LEFT JOIN Data_Teknisi t ON dt.Id_Teknisi = t.Id_Teknisi
                LEFT JOIN Data_Produk p ON dt.Id_Produk = p.Id_Produk
                WHERE dt.Id_Transaksi = @IdTransaksi";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdTransaksi", idTransaksi);

                    try
                    {
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                detailList.Add(new M_DetailTransaksi
                                {
                                    Id_Detail_Transaksi = reader.GetInt32(reader.GetOrdinal("Id_Detail_Transaksi")),
                                    Id_Transaksi = reader.GetInt32(reader.GetOrdinal("Id_Transaksi")),
                                    Id_Alat = reader.GetInt32(reader.GetOrdinal("Id_Alat")),
                                    Id_Produk = reader.GetInt32(reader.GetOrdinal("Id_Produk")),
                                    Id_Kasir = reader.GetInt32(reader.GetOrdinal("Id_Kasir")),
                                    Jumlah = reader.GetInt32(reader.GetOrdinal("Jumlah")),
                                    Total_Harga = reader.GetDecimal(reader.GetOrdinal("Total_Harga")),
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        throw;
                    }
                }
            }

            return detailList;
        }

        public void LoadRiwayatTransaksi()
        {
            try
            {
                var transaksiList = GetRiwayatTransaksi();
                Riwayat.dgvLay.Rows.Clear();
                int no = 1;
                foreach (var transaksi in transaksiList)
                {
                    string namaKasir = GetNamaKasirById(transaksi.Id_Kasir);

                    Riwayat.dgvLay.Rows.Add(
                        no++,
                        transaksi.Id_Transaksi,
                        transaksi.Nama_Pembeli,
                        transaksi.Kode_Penjualan,
                        namaKasir,
                        transaksi.Tanggal_Transaksi.ToString("dd/MM/yyyy"),
                        transaksi.Total_Harga.ToString("C")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadDetailTransaksi(int idTransaksi, DataGridView dgvDetail)
        {
            try
            {
                var detailList = GetDetailTransaksi(idTransaksi);
                dgvDetail.Rows.Clear();

                foreach (var detail in detailList)
                {
                    string namaKasir = detail.Id_Kasir != 0 ? GetNamaKasirById(detail.Id_Kasir) : "-";
                    string namaAlat = detail.Id_Alat != 0 ? GetNamaAlatById(detail.Id_Alat) : "-";
                    string namaProduk = detail.Id_Produk != 0 ? GetNamaProdukById(detail.Id_Produk) : "-";
                    dgvDetail.Rows.Add(
                        idTransaksi,
                        namaKasir,
                        namaAlat,
                        namaProduk,
                        detail.Jumlah,
                        detail.Total_Harga.ToString("C")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load Detail Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetNamaAlatById(int idAlat)
        {
            string namaAlat = string.Empty;

            using (var conn = new NpgsqlConnection(addres))
            {
                string query = "SELECT Nama_Alat FROM Data_Alat WHERE Id_Alat = @IdAlat";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdAlat", idAlat);
                    try
                    {
                        conn.Open();
                        namaAlat = cmd.ExecuteScalar().ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return namaAlat;
        }

        private string GetNamaKasirById(int idKasir)
        {
            string namaKasir = string.Empty;

            using (var conn = new NpgsqlConnection(addres))
            {
                string query = "SELECT Nama_Kasir FROM Data_Kasir WHERE Id_Kasir = @IdKasir";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdKasir", idKasir);
                    try
                    {
                        conn.Open();
                        namaKasir = cmd.ExecuteScalar().ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return namaKasir;
        }

        public string GetNamaProdukById(int idProduk)
        {
            string namaProduk = string.Empty;

            using (var conn = new NpgsqlConnection(addres))
            {
                string query = "SELECT Nama_Produk FROM Data_Produk WHERE Id_Produk = @IdProduk";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdProduk", idProduk);
                    try
                    {
                        conn.Open();
                        namaProduk = cmd.ExecuteScalar().ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return namaProduk;
        }

        public DataTable SearchRiwayatTransaksi(string searchText)
        {
            string query = @"
            SELECT 
                dt.Id_Transaksi, 
                dt.Nama_Pemilik, 
                dt.No_Kendaraan, 
                dt.Id_Kasir, 
                k.Nama_Kasir, 
                dt.Total_Harga, 
                dt.Tanggal_Transaksi
            FROM 
                Data_Transaksi dt
            LEFT JOIN 
                Data_Kasir k ON dt.Id_Kasir = k.Id_Kasir
            WHERE 
                LOWER(dt.Nama_Pemilik) LIKE LOWER(@SearchText)
                OR LOWER(dt.No_Kendaraan) LIKE LOWER(@SearchText)
            ORDER BY 
                dt.Tanggal_Transaksi DESC";

            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    DataTable dataTable = new DataTable();
                    dataTable.Load(cmd.ExecuteReader());
                    dataTable.Columns.Add("No", typeof(int));

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        dataTable.Rows[i]["No"] = i + 1;
                    }

                    return dataTable;
                }
            }
        }
    }
}