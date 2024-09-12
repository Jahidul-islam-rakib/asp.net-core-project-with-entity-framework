using MasjidManagement.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MasjidManagement.Controllers
{
	public class ImamController : Controller
	{
		private readonly MasjidDbContext _context;

		public ImamController(MasjidDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var ImamList = _context.Imams.ToList();
			return View(ImamList);
		}
	}
}
