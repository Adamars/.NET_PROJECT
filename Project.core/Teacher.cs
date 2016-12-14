using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.core
{
    public class Teacher
    {
        [Required]
        public Guid TeacherId { get; set; }
        [Required]
        [MaxLength(100)]
        public string TeacherFirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string TeacherLastName { get; set; }
        [Required]
        [MaxLength(100)]
        public int Avaible { get; set; }
    }
}
