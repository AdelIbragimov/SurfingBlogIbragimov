using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestIbragimov.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Display( Name ="Имя")]
        public string Name { get; set; }
        [Display(Name = "Пароль")]
        public string Password { get; set; }
        [Display(Name = "О себе")]
        public string About { get; set; }

    }
}
