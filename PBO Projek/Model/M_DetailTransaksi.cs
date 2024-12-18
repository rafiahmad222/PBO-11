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
        public int Id_Detail_Servis { get; set; }
        [ForeignKey("M_Servis")]
        public int Id_Servis { get; set; }
        [ForeignKey("M_Layanan")]
        public int Id_Layanan { get; set; }
        [ForeignKey("M_Teknisi")]
        public int Id_Teknisi { get; set; }
        [ForeignKey("M_SukuCadang")]
        public int Id_Suku_Cadang { get; set; }
        [Required]
        public int Jumlah { get; set; }
        [Required]
        public decimal Harga { get; set; }
    }
}
