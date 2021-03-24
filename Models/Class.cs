using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Apka_NET.Models
{
    public class Address
    {
        [Display(Name = "Podaj numer:")]
        [Required(ErrorMessage = "Pole jest obowiązkowe!")]
        public int Number { get; set; }
        public string Napis { get; set; }
        public string NumberString { get; set; }
        public DateTime SystemTime { get; set; }
    }
}
