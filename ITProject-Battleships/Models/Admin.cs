using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITProject_Battleships.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedUserData { get; set; }
        public DateTime LastLogin { get; set; }

    }
}
