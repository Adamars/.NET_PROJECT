using System;
using System.ComponentModel.DataAnnotations;

namespace bachloretteApp.Core
{
    public class Teacher
    {
        [Required]
        public Guid TeacherID { get; set; }
        [Required]
        public string TeacherFirstName { get; set; }
        [Required]
        public string TeacherLastName { get; set; }
        [Required]
        public int AvailablePositions { get; set; }
    }
}
