using Npgsql;
using PBO_Projek.Core;
using PBO_Projek.Model;
using PBO_Projek.Views.Teknisi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Projek.Controller
{
    public class C_Transaksi : Connector
    {
        C_Homepage Controller;
        V_Transaksi TransaksiView;

        public C_Transaksi(C_Homepage controller, V_Transaksi transaksiView)
        {
            Controller = controller;
            this.TransaksiView = transaksiView;
        }

        public List<M_Kasir> GetAllKasir()
        {
            List<M_Kasir> kasirList = new List<M_Kasir>();

            using (var conn = new NpgsqlConnection(addres))
            {
                string query = "SELECT Id_Kasir, Nama_Kasir FROM Data_Kasir";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                kasirList.Add(new M_Kasir
                                {
                                    Id_Kasir = reader.GetInt32(reader.GetOrdinal("Id_Kasir")),
                                    Nama_Kasir = reader.GetString(reader.GetOrdinal("Nama_Kasir"))
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            return kasirList;
        }

        public List<M_Alat> GetAllAlat()
        {
            List<M_Alat> alatList = new List<M_Alat>();
            using (var conn = new NpgsqlConnection(addres))
            {
                string query = "SELECT Id_Alat, Nama_Alat, Harga_Alat FROM Data_AlatPertanian";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                alatList.Add(new M_Alat
                                {
                                    Id_Alat = reader.GetInt32(reader.GetOrdinal("Id_Alat")),
                                    Nama_Alat = reader.GetString(reader.GetOrdinal("Nama_Alat")),
                                    Harga_Alat = reader.GetDecimal(reader.GetOrdinal("Harga_Alat"))
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            return alatList;
        }

        public List<M_Produk> GetAllProduk()
        {
            var produkList = new List<M_Produk>();
            using (var conn = new NpgsqlConnection(addres))
            {
                string query = "SELECT Id_Produk, Nama_Produk, Harga FROM Data_Produk";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                produkList.Add(new M_Produk
                                {
                                    Id_Produk = reader.GetInt32(0),
                                    Nama_Produk = reader.GetString(1),
                                    Harga = reader.GetDecimal(2)
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            return produkList;
        }

        public int GetStokProduk(int idProduk)
        {
            using (var conn = new NpgsqlConnection(addres))
            {
                string query = "SELECT Stok FROM Data_Produk WHERE Id_Produk = @IdProduk";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@IdProduk", idProduk);
                        var result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int stok))
                        {
                            return stok;
                        }
                        return 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return 0;
                    }
                }
            }
        }

        public void SimpanTransaksi(M_Transaksi transaksiHeader, List<M_DetailTransaksi> transaksiDetails)
        {
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        string queryHeader = @"
                INSERT INTO Data_Transaksi (Nama_Pembeli, Kode_Penjualan, Id_Kasir, Total_Harga, Tanggal_Transaksi)
                VALUES (@NamaPembeli, @KodePenjualan, @IdKasir, @TotalHarga, @TanggalTransaksi)
                RETURNING Id_Transaksi;";

                        int idTransaksi;
                        using (var cmd = new NpgsqlCommand(queryHeader, conn))
                        {
                            cmd.Parameters.AddWithValue("@NamaPembeli", transaksiHeader.Nama_Pembeli);
                            cmd.Parameters.AddWithValue("@KodePenjualan", transaksiHeader.Kode_Penjualan);
                            cmd.Parameters.AddWithValue("@IdKasir", transaksiHeader.Id_Kasir);
                            cmd.Parameters.AddWithValue("@TotalHarga", transaksiHeader.Total_Harga);
                            cmd.Parameters.AddWithValue("@TanggalTransaksi", transaksiHeader.Tanggal_Transaksi);
                            idTransaksi = (int)cmd.ExecuteScalar();
                        }

                        string queryDetail = @"
                INSERT INTO Detail_Transaksi (Id_Transaksi, Id_Alat, Id_Produk, Id_Kasir, Jumlah, Harga)
                VALUES (@IdTransaksi, @IdAlat, @IdProduk, @IdKasir, @Jumlah, @Harga);";

                        string queryUpdateStok = @"
                UPDATE Data_Produk
                SET Stok = Stok - @Jumlah
                WHERE Id_Produk = @IdProduk AND Stok >= @Jumlah;";

                        foreach (var detail in transaksiDetails)
                        {
                            using (var cmdDetail = new NpgsqlCommand(queryDetail, conn))
                            {
                                cmdDetail.Parameters.AddWithValue("@IdTransaksi", idTransaksi);
                                cmdDetail.Parameters.AddWithValue("@IdAlat", detail.Id_Alat > 0 ? (object)detail.Id_Alat : DBNull.Value);
                                cmdDetail.Parameters.AddWithValue("@IdProduk", detail.Id_Produk > 0 ? (object)detail.Id_Produk : DBNull.Value);
                                cmdDetail.Parameters.AddWithValue("@IdKasir", detail.Id_Kasir);
                                cmdDetail.Parameters.AddWithValue("@Jumlah", detail.Jumlah);
                                cmdDetail.Parameters.AddWithValue("@Harga", detail.Total_Harga);
                                cmdDetail.ExecuteNonQuery();
                            }

                            if (detail.Id_Produk > 0)
                            {
                                using (var cmdUpdateStok = new NpgsqlCommand(queryUpdateStok, conn))
                                {
                                    cmdUpdateStok.Parameters.AddWithValue("@IdProduk", detail.Id_Produk);
                                    cmdUpdateStok.Parameters.AddWithValue("@Jumlah", detail.Jumlah);
                                    int rowsAffected = cmdUpdateStok.ExecuteNonQuery();
                                    if (rowsAffected == 0)
                                    {
                                        throw new Exception($"Stok tidak mencukupi untuk produk dengan ID: {detail.Id_Produk}");
                                    }
                                }
                            }
                        }

                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new Exception($"Gagal menyimpan transaksi: {ex.Message}", ex);
                    }
                }
            }
        }
    }
}
