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
                SELECT ds.Id_Servis, ds.Nama_Pemilik, ds.No_Kendaraan, 
                    ds.Id_Kasir, k.Nama_Kasir, 
                    ds.Total_Harga, ds.Tanggal_Servis
                FROM Data_Servis ds
                LEFT JOIN Data_Kasir k ON ds.Id_Kasir = k.Id_Kasir  
                ORDER BY ds.Tanggal_Servis DESC";


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
                                    Id_Servis = reader.GetInt32(reader.GetOrdinal("Id_Servis")),
                                    Nama_Pemilik = reader.GetString(reader.GetOrdinal("Nama_Pemilik")),
                                    No_Kendaraan = reader.GetString(reader.GetOrdinal("No_Kendaraan")),
                                    Id_Kasir = reader.GetInt32(reader.GetOrdinal("Id_Kasir")),
                                    Total_Harga = reader.GetDecimal(reader.GetOrdinal("Total_Harga")),
                                    Tanggal_Servis = reader.GetDateTime(reader.GetOrdinal("Tanggal_Servis"))
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

        public List<M_DetailTransaksi> GetDetailServis(int idServis)
        {
            var detailList = new List<M_DetailTransaksi>();

            using (var conn = new NpgsqlConnection(addres))
            {
                string query = @"
            SELECT ds.Id_Detail_Servis, ds.Id_Servis, ds.Id_Layanan, ds.Id_Suku_Cadang, 
                ds.Jumlah, ds.Harga, ds.Id_Teknisi, t.Nama_Teknisi, sc.Nama_Suku_Cadang
            FROM Detail_Servis ds
            LEFT JOIN Data_Teknisi t ON ds.Id_Teknisi = t.Id_Teknisi
            LEFT JOIN Data_Suku_Cadang sc ON ds.Id_Suku_Cadang = sc.Id_Suku_Cadang
            WHERE ds.Id_Servis = @IdServis";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdServis", idServis);

                    try
                    {
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                detailList.Add(new M_DetailTransaksi
                                {
                                    Id_Detail_Servis = reader.GetInt32(reader.GetOrdinal("Id_Detail_Servis")),
                                    Id_Servis = reader.GetInt32(reader.GetOrdinal("Id_Servis")),
                                    Id_Layanan = reader.IsDBNull(reader.GetOrdinal("Id_Layanan")) ? 0 : reader.GetInt32(reader.GetOrdinal("Id_Layanan")),
                                    Id_Suku_Cadang = reader.IsDBNull(reader.GetOrdinal("Id_Suku_Cadang")) ? 0 : reader.GetInt32(reader.GetOrdinal("Id_Suku_Cadang")),
                                    Jumlah = reader.GetInt32(reader.GetOrdinal("Jumlah")),
                                    Harga = reader.GetDecimal(reader.GetOrdinal("Harga")),
                                    Id_Teknisi = reader.IsDBNull(reader.GetOrdinal("Id_Teknisi")) ? 0 : reader.GetInt32(reader.GetOrdinal("Id_Teknisi")) 
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
                var servisList = GetRiwayatTransaksi();
                Riwayat.dgvLay.Rows.Clear();
                int no = 1;
                foreach (var servis in servisList)
                {
                    string namaKasir = GetNamaKasirById(servis.Id_Kasir);

                    Riwayat.dgvLay.Rows.Add(
                        no++,
                        servis.Id_Servis,
                        servis.Nama_Pemilik,
                        servis.No_Kendaraan,
                        namaKasir,
                        servis.Tanggal_Servis.ToString("dd/MM/yyyy"),
                        servis.Total_Harga.ToString("C")
                    );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadDetailServis(int idServis, DataGridView dgvDetail)
        {
            try
            {
                var detailList = GetDetailServis(idServis);
                dgvDetail.Rows.Clear();

                foreach (var detail in detailList)
                {
                    string namaTeknisi = detail.Id_Teknisi != 0 ? GetNamaTeknisiById(detail.Id_Teknisi) : "-";
                    string namaLayanan = detail.Id_Layanan != 0 ? GetNamaLayananById(detail.Id_Layanan) : "-";
                    string namaSukuCadang = detail.Id_Suku_Cadang != 0 ? GetNamaSukuCadangById(detail.Id_Suku_Cadang) : "-";

                    dgvDetail.Rows.Add(
                        idServis,
                        namaTeknisi, 
                        namaLayanan,
                        namaSukuCadang,
                        detail.Jumlah,
                        detail.Harga.ToString("C")
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load Detail Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private string GetNamaTeknisiById(int idTeknisi)
        {
            string namaTeknisi = string.Empty;

            using (var conn = new NpgsqlConnection(addres))
            {
                string query = "SELECT Nama_Teknisi FROM Data_Teknisi WHERE Id_Teknisi = @IdTeknisi";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdTeknisi", idTeknisi);
                    try
                    {
                        conn.Open();
                        namaTeknisi = cmd.ExecuteScalar().ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return namaTeknisi;
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

        public string GetNamaLayananById(int idLayanan)
        {
            string namaLayanan = string.Empty;

            using (var conn = new NpgsqlConnection(addres))
            {
                string query = "SELECT Nama_Layanan FROM Data_Layanan WHERE Id_Layanan = @IdLayanan";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdLayanan", idLayanan);

                    try
                    {
                        conn.Open();
                        namaLayanan = cmd.ExecuteScalar().ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return namaLayanan;
        }
        public string GetNamaSukuCadangById(int idSukuCadang)
        {
            string namaSukuCadang = string.Empty;

            using (var conn = new NpgsqlConnection(addres))
            {
                string query = "SELECT Nama_Suku_Cadang FROM Data_Suku_Cadang WHERE Id_Suku_Cadang = @IdSukuCadang";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdSukuCadang", idSukuCadang);

                    try
                    {
                        conn.Open();
                        namaSukuCadang = cmd.ExecuteScalar().ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return namaSukuCadang;
        }

        public DataTable SearchRiwayatTransaksi(string searchText)
        {
            string query = @"
    SELECT 
        ds.Id_Servis, 
        ds.Nama_Pemilik, 
        ds.No_Kendaraan, 
        ds.Id_Kasir, 
        k.Nama_Kasir, 
        ds.Total_Harga, 
        ds.Tanggal_Servis
    FROM 
        Data_Servis ds
    LEFT JOIN 
        Data_Kasir k ON ds.Id_Kasir = k.Id_Kasir
    WHERE 
        LOWER(ds.Nama_Pemilik) LIKE LOWER(@SearchText)
        OR LOWER(ds.No_Kendaraan) LIKE LOWER(@SearchText)
    ORDER BY 
        ds.Tanggal_Servis DESC";

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

