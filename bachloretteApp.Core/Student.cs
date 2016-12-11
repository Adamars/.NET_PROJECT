using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bachloretteApp.Core
{
    public class Student
    {
        [Required]
        public Guid StudentID { get; set; }
        [Required]
        public string StudentFirstName { get; set; }
        [Required]
        public string StudentLastName { get; set; }
        [Required]
        public int StudentMeanFirstYear { get; set; }
        [Required]
        public int StudentMeanSecondYear { get; set; }
        [Required]
        public string StudentPreferences { get; set; }
    }
}
