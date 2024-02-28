using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public class ProfessorClass
    {
        [Key]
        public int id { get; set; }
        public int profId { get; set; }
        public string classCode { get; set; }
        public int userId { get; set; }
    }
}
