using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.DB
{
	public class HotelDbcontext : DbContext
	{
		public HotelDbcontext(DbContextOptions<HotelDbcontext>options) :base (options)
		{
		}

        public DbSet<Hotel>Hotels { get; set; }
    }
}
