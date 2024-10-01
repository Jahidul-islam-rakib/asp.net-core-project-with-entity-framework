using MasjidManagement.DB;
using MasjidManagement.Models;
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

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(PrayerTime prayerTime)
		{
			_context.SalatTime.Add(prayerTime);
			_context.SaveChanges();

			return View();
		}

		public IActionResult Update(int id)
		{
			PrayerTime? prayerTime = _context.SalatTime.ToList().FirstOrDefault(x => x.Id == id);

			return View(prayerTime);
		}

		[HttpPost]
		public IActionResult Update(PrayerTime prayerTime)
		{
			if (prayerTime.Id > 0)
			{
				_context.SalatTime.Update(prayerTime);
				_context.SaveChanges();

				return RedirectToAction("Index");
			}
			else
			{
				return RedirectToAction("Index");
			}
		}

		public IActionResult Delete(int id)
		{
			var prayerTime = _context.SalatTime.FirstOrDefault(x => x.Id == id);

			if (prayerTime != null)
			{
				_context.SalatTime.Remove(prayerTime);
				_context.SaveChanges();
			}

			return RedirectToAction("Index");

		}
	}
}
