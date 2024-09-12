using LibraryManagement.DB;
using Microsoft.AspNetCore.Mvc;

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
			return View();
		}

		public IActionResult Create()
		{
			return View();
		}
	}
}
