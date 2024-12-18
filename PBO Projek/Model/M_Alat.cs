using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Projek.Model
{
    public class M_Alat
    {
        [Key]
        public int Id_Layanan { get; set; }
        [Required]
        public string Nama_Layanan { get; set; }
        [Required]
        public decimal Harga_Layanan { get; set; }
    }
}
