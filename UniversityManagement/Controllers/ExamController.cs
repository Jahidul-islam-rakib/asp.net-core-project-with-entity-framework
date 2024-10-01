using Microsoft.AspNetCore.Mvc;
using UniversityManagement.DB;
using UniversityManagement.Models;


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

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Exam exam)
		{
			_context.Exams.Add(exam);
			_context.SaveChanges();

			return View();
		}

		public IActionResult Update(int id)
		{
			Exam? exam = _context.Exams.ToList().FirstOrDefault(x => x.Id == id);
			return View(exam);
		}

		[HttpPost]
		public IActionResult Update(Exam exam)
		{
			if (exam.Id > 0)
			{
				_context.Exams.Update(exam);
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
			var course = _context.Exams.FirstOrDefault(x => x.Id == id);

			if (course != null)
			{
				_context.Exams.Remove(course);
				_context.SaveChanges();
			}
			return RedirectToAction("Index");
		}


	}
}
