using LibraryManagement.Controllers;
using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.DB
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {

        }

        public DbSet<Library>Librarys{get; set;}
        public DbSet<Student> Students{get; set;}
        public DbSet<Book> Books{get; set;}
        public DbSet<Loan> Loans{get; set;}
        public DbSet<Category> Categories{get; set;}
        public DbSet<Staff>Staffs{get; set;}
    }
}
