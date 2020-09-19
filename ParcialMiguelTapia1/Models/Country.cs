using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialMiguelTapia1.Models
{
    public class Lenguas
    {
        [Key]
        [StringLength(2, MinimumLength = 1)]
        public string iso639_1 { get; set; }
        [StringLength(3, MinimumLength = 1)]
        public string iso639_2 { get; set; }
        [StringLength(20, MinimumLength = 3)]
        public string Nombre { get; set; }
        [StringLength(20, MinimumLength = 3)]
        public string nativeName { get; set; }

    }
    public class Country
    {
        [Key]
        [Required]
        [StringLength(3)]
        public string alpha3Code { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Inserte una region")]
        public string region { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Inserte un nombre")]
        public string name { get; set; }
        [Required]
        [Range(0, 10000000)]
        public double area { get; set; }
        [Required]
        [Range(0, 999)]
        public int callingCodes { get; set; }
        
        [Required]
        public List<Lenguas> Languages { get; set; }

    }
}