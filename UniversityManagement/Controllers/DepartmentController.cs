using Microsoft.AspNetCore.Mvc;
using UniversityManagement.DB;
using UniversityManagement.Models;

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
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();

            return View();
        }

		public IActionResult Update(int id)
		{
			Department? department = _context.Departments.ToList().FirstOrDefault(x => x.Id == id);
			return View(department);
		}

		[HttpPost]
		public IActionResult Update(Department department)
		{
			if (department.Id > 0)
			{
				_context.Departments.Update(department);
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
			var course = _context.Departments.FirstOrDefault(x => x.Id == id);

			if (course != null)
			{
				_context.Departments.Remove(course);
				_context.SaveChanges();
			}
			return RedirectToAction("Index");
		}
	}
}
