using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BacheloretteManager.Core
{
    public class Student : User
    {
        [Required]
        public double MeanA1 { get; set; }

        [Required]
        public double MeanA2 { get; set; }

        [Required]
        [MaxLength(100)]
        public string Preferences { get; set; }

        public User User { get; set; }
    }
}
