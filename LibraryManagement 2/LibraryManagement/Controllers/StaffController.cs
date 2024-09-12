using LibraryManagement.DB;
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
	}
}
