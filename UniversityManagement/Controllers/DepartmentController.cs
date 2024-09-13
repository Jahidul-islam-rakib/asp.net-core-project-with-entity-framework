using Microsoft.AspNetCore.Mvc;
using UniversityManagement.DB;

namespace UniversityManagement.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly UniversityDbContext _context;

        public DepartmentController(UniversityDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var ListOfDept = _context.Departments.ToList();
            return View(ListOfDept);
        }
    }
}
