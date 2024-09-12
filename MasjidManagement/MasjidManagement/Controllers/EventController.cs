using MasjidManagement.DB;
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
    }
}
