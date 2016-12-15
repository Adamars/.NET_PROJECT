using System;
using System.ComponentModel.DataAnnotations;

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
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [MaxLength(100)]
        public int Avaible { get; set; }
    }
}
