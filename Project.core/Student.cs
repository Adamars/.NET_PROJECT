using System;
using System.ComponentModel.DataAnnotations;

namespace Project.core
{
    public class Student
    {
        [Required]
        public Guid StudentId { get; set; }
        [Required]
        [MaxLength(100)]
        public string StudentFirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string StudentLastName { get; set; }
        [Required]
        [MaxLength(100)]
        public double MeanA1 { get; set; }
        public double MeanA2 { get; set; }
        [Required]
        [MaxLength(100)]
        public string Preferences { get; set; }
    }
}
