using LibraryManagement.DB;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
	public class BookController : Controller
	{
		private readonly LibraryDbContext _context;

		public BookController(LibraryDbContext context)
		{
			_context = context;
		}


		public IActionResult Index()
		{
			var ListOfBooks = _context.Books.ToList();
			return View(ListOfBooks);
		}


		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Book book)
		{
			_context.Books.Add(book);
			_context.SaveChanges();

			return View();
		}

		public IActionResult Update(int id)
		{
			Book book = _context.Books.ToList().FirstOrDefault(x => x.Id == id);

			return View(book);
		}

		[HttpPost]
		public IActionResult Update(Book book)
		{
			if(book.Id > 0)
			{
				_context.Books.Update(book);
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
			var book = _context.Books.FirstOrDefault(x => x.Id == id);

			if(book != null)
			{
				_context.Books.Remove(book);
				_context.SaveChanges();

			}

			return RedirectToAction("Index");
		}

	}
}
