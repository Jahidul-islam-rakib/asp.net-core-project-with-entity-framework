using LibraryManagement.DB;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
	public class LoanController : Controller
	{
		public readonly LibraryDbContext _context;

		public LoanController(LibraryDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			var ListOfLoan = _context.Loans.ToList();
			return View(ListOfLoan);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Loan loanBook)
		{
			_context.Loans.Add(loanBook);
			_context.SaveChanges();

			return View();
		}

		public IActionResult Update(int id)
		{
			Loan? loan = _context.Loans.ToList().FirstOrDefault(x => x.Id == id);

			return View(loan);
		}

		[HttpPost]
		public IActionResult Update(Loan loan)
		{
			if(loan.Id >0)
			{
				_context.Loans.Update(loan);
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
			var loan = _context.Loans.FirstOrDefault(x => x.Id == id);

			if(loan !=null)
			{
				_context.Loans.Remove(loan);
				_context.SaveChanges();
			}

			return RedirectToAction("Index");
		}
	}
}
