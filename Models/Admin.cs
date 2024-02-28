using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        
        public string userName { get; set; }
        public string password { get; set; }

    }
}
