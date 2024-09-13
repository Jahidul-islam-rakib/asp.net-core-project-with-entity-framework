using Microsoft.AspNetCore.Mvc;
using UniversityManagement.DB;

namespace UniversityManagement.Controllers
{
	public class ExamController : Controller
	{
		private readonly UniversityDbContext _context;

        public ExamController(UniversityDbContext context)
        {
			_context = context;   
        }
        public IActionResult Index()
		{
			var ExamList = _context.Exams.ToList();
			return View(ExamList);
		}
	}
}
