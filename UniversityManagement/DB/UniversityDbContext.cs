using Microsoft.EntityFrameworkCore;
using UniversityManagement.Models;

namespace UniversityManagement.DB
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext>Options) : base(Options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course>Courses { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Exam> Exams { get; set; }  
    }


}
