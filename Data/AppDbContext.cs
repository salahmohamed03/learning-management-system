using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchoolManagementSystem.Models;
namespace WinFormsApp1.Data
{
    public class AppDbContext :DbContext
    {
        // Tables
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }
        public DbSet<Professor> professors { get; set; }
        public DbSet<ProfessorClass> professorClasses { get; set; }
        public DbSet<Class> classes { get; set; }
        public DbSet<Admin> admins { get; set; }

        // Conecting the data base with the class 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(connectionString: config.GetConnectionString("Default"));
        }
    }
}
