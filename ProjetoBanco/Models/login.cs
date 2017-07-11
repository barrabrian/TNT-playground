using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoBanco.Models
{
    [Table("login")]
    public class login
    {
        [Index(IsUnique = true)]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Index(IsUnique = true)]
        public string username { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string password { get; set; } 

    }
}