using LibraryManagement.DB;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
	public class StaffController : Controller
	{
		public readonly LibraryDbContext _context;

		public StaffController(LibraryDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var ListOfStaff = _context.Staffs.ToList();
			return View(ListOfStaff);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Staff staff)
		{
			_context.Staffs.Add(staff);
			_context.SaveChanges();

			return View();
		}

		public IActionResult Update(int id)
		{
			Staff? staff = _context.Staffs.ToList().FirstOrDefault(x => x.Id == id);

			return View(staff);
		}

		[HttpPost]
		public IActionResult Update(Staff staff) 
		{
			  if(staff.Id > 0)
			{
				_context.Staffs.Update(staff);
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
			var prayer = _context.Staffs.FirstOrDefault(pr => pr.Id == id);

			if (prayer != null)
			{
				_context.Staffs.Remove(prayer);
				_context.SaveChanges();
			}
			return RedirectToAction("Index");

		}
	}
}
