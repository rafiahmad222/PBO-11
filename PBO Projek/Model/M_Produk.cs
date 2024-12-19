using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Projek.Model
{
    public class M_Produk
    {
        [Key]
        public int Id_Produk { get; set; }
        [Required]
        public string Nama_Produk { get; set; }
        [Required]
        public decimal Harga { get; set; }
        [Required]
        public int Stok { get; set; }
        [Required]
        public int Id_Kategori { get; set; }
        public string Nama_Kategori { get; set; }


    }

}
