using LibraryManagement.DB;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
	public class CategoryController : Controller
	{

		private readonly LibraryDbContext _context;

		public CategoryController(LibraryDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var ListOfCategory = _context.Categories.ToList();
			return View(ListOfCategory);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Category category)
		{
			_context.Categories.Add(category);
			_context.SaveChanges();

			return View();
		}

		public IActionResult Update(int id)
		{
			Category? category = _context.Categories.ToList().FirstOrDefault(x => x.Id == id);

			return View(category);
		}

		[HttpPost]
		public IActionResult Update(Category category)
		{
			if (category.Id > 0)
			{
				_context.Categories.Update(category);
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
			var category = _context.Categories.FirstOrDefault(x => x.Id == id);
			if (category != null)
			{
				_context.Categories.Remove(category);
				_context.SaveChanges();
			}

			return RedirectToAction("Index");
		}
	}
}