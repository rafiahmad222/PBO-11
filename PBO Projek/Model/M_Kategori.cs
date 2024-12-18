using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Projek.Model
{
    public class M_Kategori
    {
        [Key]
        public int Id_Kategori { get; set; }
        [Required]
        public string Nama_Kategori { get; set; }
        
    }
}
