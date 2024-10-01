using LibraryManagement.DB;
using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Models;

namespace LibraryManagement.Controllers
{
	public class LibraryController : Controller
	{
		private readonly LibraryDbContext _context;

		public LibraryController (LibraryDbContext context)
		{
			_context = context;  
		}
		public IActionResult Index()
		{
			var list = _context.Librarys.ToList();
			return View(list);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Library library)
		{
			_context.Librarys.Add(library);
			_context.SaveChanges();

			return View();
		}

	}
}
