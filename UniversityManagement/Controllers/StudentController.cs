using Microsoft.AspNetCore.Mvc;
using UniversityManagement.DB;
using UniversityManagement.Models;

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

        public IActionResult Create() 
            {
            return View();
            }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();

            return View();
        }

		public IActionResult Update(int id)
		{
			Student? student = _context.Students.ToList().FirstOrDefault(x => x.Id == id);
			return View(student);
		}

		[HttpPost]
		public IActionResult Update(Student student)
		{
			if (student.Id > 0)
			{
				_context.Students.Update(student);
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
			var course = _context.Students.FirstOrDefault(x => x.Id == id);

			if (course != null)
			{
				_context.Students.Remove(course);
				_context.SaveChanges();
			}
			return RedirectToAction("Index");
		}
	}
}
