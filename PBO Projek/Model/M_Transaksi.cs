using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Projek.Model
{
    public class M_Transaksi
    {
        [Key]
        public int Id_Transaksi { get; set; }
        [Required]
        public string Nama_Pembeli { get; set; }
        [Required]
        public string Kode_Penjualan { get; set; }
        [ForeignKey("M_Kasir")]
        public int Id_Kasir { get; set; }
        [Required]
        public decimal Total_Harga { get; set; }
        public DateTime Tanggal_Transaksi { get; set; }
    }
}

