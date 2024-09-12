using MasjidManagement.DB;
using Microsoft.AspNetCore.Mvc;

namespace MasjidManagement.Controllers
{
	public class VolunteerController : Controller
	{
		private readonly MasjidDbContext _context;

        public VolunteerController(MasjidDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
		{
			var VolunteerList = _context.Volunteers.ToList();
			return View(VolunteerList);
		}
	}
}
