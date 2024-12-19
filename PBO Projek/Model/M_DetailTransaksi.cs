using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Projek.Model
{
    public class M_DetailTransaksi
    {
        [Key]
        public int Id_Detail_Transaksi { get; set; }
        [ForeignKey("M_Transaksi")]
        public int Id_Transaksi { get; set; }
        [ForeignKey("M_Alat")]
        public int Id_Alat { get; set; }
        [ForeignKey("M_Kasir")]
        public int Id_Kasir { get; set; }
        [ForeignKey("M_Produk")]
        public int Id_Produk { get; set; }
        [Required]
        public int Jumlah { get; set; }
        [Required]
        public decimal Total_Harga { get; set; }
       
    }
}
