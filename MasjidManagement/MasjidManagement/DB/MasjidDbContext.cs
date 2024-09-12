using Microsoft.EntityFrameworkCore;
using MasjidManagement.Models;

namespace MasjidManagement.DB
{
    public class MasjidDbContext:DbContext
    {
        public MasjidDbContext(DbContextOptions<MasjidDbContext> options) : base(options) {
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Donation>Donors { get; set; }
        public DbSet<Imam>Imams { get; set; }
        public DbSet<PrayerTime> SalatTime { get; set; }
        public DbSet<Volunteer> Volunteers { get; set;}
    }
}
