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
        V_Transaksi Servis;

        public C_Transaksi(C_Homepage controller, V_Transaksi servis)
        {
            Controller = controller;
            this.Servis = servis;
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


        public List<M_Alat> GetAllLayanan()
        {
            var layananList = new List<M_Alat>();
            using (var conn = new NpgsqlConnection(addres))
            {
                string query = "SELECT Id_Layanan, Nama_Layanan, Harga_Layanan FROM Data_Layanan";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                layananList.Add(new M_Alat
                                {
                                    Id_Layanan = reader.GetInt32(0),
                                    Nama_Layanan = reader.GetString(1),
                                    Harga_Layanan = reader.GetDecimal(2)
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
            return layananList;
        }

        public List<M_Produk> GetAllSukuCadang()
        {
            var sukuCadangList = new List<M_Produk>();
            using (var conn = new NpgsqlConnection(addres))
            {
                string query = "SELECT Id_Suku_Cadang, Nama_Suku_Cadang, Harga FROM Data_Suku_Cadang";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                sukuCadangList.Add(new M_Produk
                                {
                                    Id_Suku_Cadang = reader.GetInt32(0),
                                    Nama_Suku_Cadang = reader.GetString(1),
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
            return sukuCadangList;
        }

        public int GetStokSukuCadang(int idSukuCadang)
        {
            using (var conn = new NpgsqlConnection(addres))
            {
                string query = "SELECT Stok FROM Data_Suku_Cadang WHERE Id_Suku_Cadang = @IdSukuCadang";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@IdSukuCadang", idSukuCadang);
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


        public void SimpanServis(M_Transaksi servisHeader, List<M_DetailTransaksi> servisDetails)
        {
            using (var conn = new NpgsqlConnection(addres))
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        string queryHeader = @"
                    INSERT INTO Data_Servis (Nama_Pemilik, No_Kendaraan, Id_Kasir, Total_Harga, Tanggal_Servis)
                    VALUES (@NamaPemilik, @NoKendaraan, @IdKasir, @TotalHarga, @TanggalServis)
                    RETURNING Id_Servis;";

                        int idServis;
                        using (var cmd = new NpgsqlCommand(queryHeader, conn))
                        {
                            cmd.Parameters.AddWithValue("@NamaPemilik", servisHeader.Nama_Pemilik);
                            cmd.Parameters.AddWithValue("@NoKendaraan", servisHeader.No_Kendaraan);
                            cmd.Parameters.AddWithValue("@IdKasir", M_Kasir.Id); 
                            cmd.Parameters.AddWithValue("@TotalHarga", servisHeader.Total_Harga);
                            cmd.Parameters.AddWithValue("@TanggalServis", servisHeader.Tanggal_Servis);
                            idServis = (int)cmd.ExecuteScalar();
                        }

                        string queryDetail = @"
                    INSERT INTO Detail_Servis (Id_Servis, Id_Layanan, Id_Suku_Cadang, Id_Teknisi, Jumlah, Harga)
                    VALUES (@IdServis, @IdLayanan, @IdSukuCadang, @IdTeknisi, @Jumlah, @Harga);";

                        string queryUpdateStok = @"
                    UPDATE Data_Suku_Cadang
                    SET Stok = Stok - @Jumlah
                    WHERE Id_Suku_Cadang = @IdSukuCadang AND Stok >= @Jumlah;";

                        foreach (var detail in servisDetails)
                        {
                            using (var cmdDetail = new NpgsqlCommand(queryDetail, conn))
                            {
                                cmdDetail.Parameters.AddWithValue("@IdServis", idServis);
                                cmdDetail.Parameters.AddWithValue("@IdLayanan", detail.Id_Layanan > 0 ? (object)detail.Id_Layanan : DBNull.Value);
                                cmdDetail.Parameters.AddWithValue("@IdSukuCadang", detail.Id_Suku_Cadang > 0 ? (object)detail.Id_Suku_Cadang : DBNull.Value);
                                cmdDetail.Parameters.AddWithValue("@IdTeknisi", detail.Id_Teknisi); 
                                cmdDetail.Parameters.AddWithValue("@Jumlah", detail.Jumlah);
                                cmdDetail.Parameters.AddWithValue("@Harga", detail.Harga);
                                cmdDetail.ExecuteNonQuery();
                            }

                            if (detail.Id_Suku_Cadang > 0)
                            {
                                using (var cmdUpdateStok = new NpgsqlCommand(queryUpdateStok, conn))
                                {
                                    cmdUpdateStok.Parameters.AddWithValue("@IdSukuCadang", detail.Id_Suku_Cadang);
                                    cmdUpdateStok.Parameters.AddWithValue("@Jumlah", detail.Jumlah);
                                    int rowsAffected = cmdUpdateStok.ExecuteNonQuery();
                                    if (rowsAffected == 0)
                                    {
                                        throw new Exception($"Stok tidak mencukupi untuk suku cadang dengan ID: {detail.Id_Suku_Cadang}");
                                    }
                                }
                            }
                        }

                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw new Exception($"Gagal menyimpan servis: {ex.Message}", ex);
                    }
                }
            }
        }



    }
}
