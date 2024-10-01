using MasjidManagement.DB;
using MasjidManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace MasjidManagement.Controllers
{
    public class EventController : Controller
    {
        private readonly MasjidDbContext _context;

        public EventController(MasjidDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var EventList = _context.Events.ToList();
            return View(EventList);
        }

		
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Event evt)
		{
			_context.Events.Add(evt);
			_context.SaveChanges();

			return View();
		}

		public IActionResult Update(int id)
		{
			Event? eventObj = _context.Events.ToList().FirstOrDefault(x =>x.Id ==id);
			
			return View(eventObj);
		}

		[HttpPost]
		public IActionResult Update(Event eventObj)
		{
			if(eventObj.Id >0)
			{
				_context.Events.Update(eventObj);
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
			var evt = _context.Events.FirstOrDefault(x => x.Id == id);

			if(evt != null)
			{
				_context.Events.Remove(evt);
				_context.SaveChanges();
			}

			return RedirectToAction("Index");
		}


}
}



