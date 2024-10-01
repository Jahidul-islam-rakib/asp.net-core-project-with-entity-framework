using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using UniversityManagement.DB;
using UniversityManagement.Models;

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

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Course course)
		{
			_context.Courses.Add(course);
			_context.SaveChanges();

			return View();
		}

		public IActionResult Update(int id)
		{
			Course? course = _context.Courses.ToList().FirstOrDefault(x => x.Id == id);
			return View(course);
		}

		[HttpPost]
		public IActionResult Update(Course course)
		{
			if (course.Id > 0)
			{
				_context.Courses.Update(course);
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
			var course = _context.Courses.FirstOrDefault(x => x.Id == id);

			if (course != null)
			{
				_context.Courses.Remove(course);
				_context.SaveChanges();
			}
			return RedirectToAction("Index");
		}
	}
}
