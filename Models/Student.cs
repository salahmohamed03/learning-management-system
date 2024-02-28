

using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }

        [StringLength(25)]
        public string? firstName { get; set; }

        [StringLength(25)]
        public string? lastName { get; set; }

        public int? age { get; set; }
        public string? phone { get; set; }

        public string? email { get; set; }

        public int? grade { get; set; }
        public int userId { get; set; }

    }
}
