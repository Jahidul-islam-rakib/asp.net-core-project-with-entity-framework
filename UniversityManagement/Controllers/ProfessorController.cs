using Microsoft.AspNetCore.Mvc;
using UniversityManagement.DB;
using UniversityManagement.Models;

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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Professor professor)
        {
            _context.Professors.Add(professor);
            _context.SaveChanges();

            return View();
        }

		public IActionResult Update(int id)
		{
			Professor? professor = _context.Professors.ToList().FirstOrDefault(x => x.Id == id);
			return View(professor);
		}

		[HttpPost]
		public IActionResult Update(Professor professor)
		{
			if (professor.Id > 0)
			{
				_context.Professors.Update(professor);
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
			var course = _context.Professors.FirstOrDefault(x => x.Id == id);

			if (course != null)
			{
				_context.Professors.Remove(course);
				_context.SaveChanges();
			}
			return RedirectToAction("Index");
		}
	}
}
