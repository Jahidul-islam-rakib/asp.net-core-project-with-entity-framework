using Microsoft.AspNetCore.Mvc;
using UniversityManagement.DB;

namespace UniversityManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly UniversityDbContext _context;

        public StudentController( UniversityDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var StdList = _context.Students.ToList();
            return View(StdList);
        }
    }
}
