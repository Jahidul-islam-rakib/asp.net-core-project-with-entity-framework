using MasjidManagement.DB;
using MasjidManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MasjidManagement.Controllers
{
	public class ImamController : Controller
	{
		private readonly MasjidDbContext _context;

		public ImamController(MasjidDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var ImamList = _context.Imams.ToList();
			return View(ImamList);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Imam imam)
		{
			_context.Imams.Add(imam);
			_context.SaveChanges();

			return View();
		}

		public IActionResult Update(int id)
		{
			Imam? imam = _context.Imams.ToList().FirstOrDefault(x => x.Id == id);

			return View(imam);
		}

		[HttpPost]
		public IActionResult Update(Imam imam) 
		{
			if(imam.Id >0)
			{
				_context.Imams.Update(imam);
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
			var imam= _context.Imams.FirstOrDefault(x => x.Id == id);

			if(imam != null)
			{
				_context.Imams.Remove(imam);
				_context.SaveChanges();
			}

			return RedirectToAction("Index");
		}
	}
}
