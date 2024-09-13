using Microsoft.AspNetCore.Mvc;
using UniversityManagement.DB;

namespace UniversityManagement.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly UniversityDbContext _context;

        public ProfessorController(UniversityDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var ProfessorList = _context.Professors.ToList();
            return View(ProfessorList);
        }
    }
}
