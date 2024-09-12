using MasjidManagement.DB;
using Microsoft.AspNetCore.Mvc;

namespace MasjidManagement.Controllers
{
	public class PrayerTimeController : Controller
	{
		private readonly MasjidDbContext _context;

		public PrayerTimeController(MasjidDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var PrayerTimeList = _context.SalatTime.ToList();
			return View(PrayerTimeList);
		}
	}
}
