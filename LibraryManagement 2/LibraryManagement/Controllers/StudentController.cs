using LibraryManagement.DB;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly LibraryDbContext _context;

        public StudentController(LibraryDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var ListOfStudents= _context.Students.ToList();
            return View(ListOfStudents); 
        }
    }
}
