using MasjidManagement.DB;
using MasjidManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Donation donation)
        {
            _context.Donors.Add(donation);
            _context.SaveChanges();

            return View();
        }

        public IActionResult Update(int id)
        {
            Donation? donation = _context.Donors.ToList().FirstOrDefault(x => x.Id == id);
            return View(donation);
        }


        [HttpPost]
        public IActionResult Update(Donation donation)
        {
            if(donation.Id> 0 )
            {
                _context.Donors.Update(donation);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult Delte(int id)
        {
            var donation = _context.Donors.FirstOrDefault(x => x.Id == id);

            if(donation != null)
            {
                _context.Donors.Remove(donation);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
