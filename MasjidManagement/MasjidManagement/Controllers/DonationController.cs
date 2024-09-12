using MasjidManagement.DB;
using Microsoft.AspNetCore.Mvc;

namespace MasjidManagement.Controllers
{
    public class DonationController : Controller
    {
        private readonly MasjidDbContext _context;

        public DonationController(MasjidDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var DonorList = _context.Donors.ToList();
            return View(DonorList);
        }
    }
}
