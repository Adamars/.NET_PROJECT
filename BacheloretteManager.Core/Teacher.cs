using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BacheloretteManager.Core
{
    public class Teacher : User
    {
        [Required]
        public string Requirements { get; set; }

        [Required]
        public int FreeSpaces { get; set; }

        [Required]
        public int Available { get; set; }

        public User User { get; set; }
    }
}
