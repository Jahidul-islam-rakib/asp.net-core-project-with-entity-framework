using Microsoft.AspNetCore.Mvc;
using UniversityManagement.DB;

namespace UniversityManagement.Controllers
{
	public class CourseController : Controller
	{
		private readonly UniversityDbContext _context;

		public CourseController(UniversityDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var CourseList = _context.Courses.ToList();
			return View(CourseList);
		}
	}
}
