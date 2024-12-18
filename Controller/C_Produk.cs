using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using PBO_Projek.Model;
using PBO_Projek.Core;
using System.Data;
using System.Windows.Forms;
using PBO_Projek.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PBO_Projek.Controller
{
    public class C_Produk : dataConnection
    {
        public bool InsertProduk(string nama_produk, )
        {
            try
            {
                string query = "INSERT INTO produk (nama_produk, harga, stok_produk, gambar_produk, kategori_produk) VALUES (@nama_produk, @harga, @stok_produk, @gambar_produk, @kategori_produk)";
                NpgsqlParameter[] parameters =
                {
                new NpgsqlParameter("@nama_produk", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = produk.nama_produk},
                new NpgsqlParameter("@harga", NpgsqlTypes.NpgsqlDbType.Integer) {Value = produk.harga},
                new NpgsqlParameter("@stok_produk", NpgsqlTypes.NpgsqlDbType.Integer) {Value = produk.stok_produk},
                new NpgsqlParameter("@gambar_produk", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = produk.gambar_produk},
                new NpgsqlParameter("@kategori_produk", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = produk.kategori_produk}
            };
            }
        }
        
        public static bool UpdateProduk(M_Produk produk)
        {
            string query = "UPDATE produk SET nama_produk = @nama_produk, harga = @harga, stok_produk = @stok_produk, gambar_produk = @gambar_produk, kategori_produk = @kategori_produk WHERE id_produk = @id_produk";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_produk", NpgsqlTypes.NpgsqlDbType.Integer) {Value = produk.id_produk},
                new NpgsqlParameter("@nama_produk", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = produk.nama_produk},
                new NpgsqlParameter("@harga", NpgsqlTypes.NpgsqlDbType.Integer) {Value = produk.harga},
                new NpgsqlParameter("@stok_produk", NpgsqlTypes.NpgsqlDbType.Integer) {Value = produk.stok_produk},
                new NpgsqlParameter("@gambar_produk", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = produk.gambar_produk},
                new NpgsqlParameter("@kategori_produk", NpgsqlTypes.NpgsqlDbType.Varchar) {Value = produk.kategori_produk}
            };
        }
        public static bool DeleteProduk(int id_produk)
        {
            string query = "DELETE FROM produk WHERE id_produk = @id_produk";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_produk", NpgsqlTypes.NpgsqlDbType.Integer) {Value = id_produk}
            };
        }
        public static DataTable SelectProduk()
        {
            string query = "SELECT * FROM produk";
            return dataConnection.queryExecutor(query);
        }
    }
}