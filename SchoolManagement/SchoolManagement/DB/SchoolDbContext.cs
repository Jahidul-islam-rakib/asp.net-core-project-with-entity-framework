using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SchoolManagement.Models;

namespace SchoolManagement.DB
{
	public class SchoolDbContext : DbContext
	{
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base (options)
        {

            
        }

        public DbSet<School> Schools { get; set; }

    }
}
