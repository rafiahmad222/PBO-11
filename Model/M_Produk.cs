using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PBO_Projek.Model
{
    public class M_Produk
    {
        [Key]
        public int id_produk { get; set; }
        [Required]
        public string nama_produk { get; set; }
        [Required]
        public int harga { get; set; }
        [Required]
        public int stok_produk { get; set; }
        [Required]
        public string gambar_produk { get; set; }
        [Required]
        public string kategori_produk { get; set; }
    }
}
