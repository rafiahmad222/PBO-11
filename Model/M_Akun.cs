using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace PBO_Projek.Model
{
    public class M_Akun
    {
        [Key] public int id { get; set; }
        [Required] public string nama { get; set; }
        [Required] public string email { get; set; }
        [Required] public string password { get; set; }
        [Required] public string username { get; set; }


    }
}
