using LibraryManagement.DB;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class StudentController : Controller
    {
        private readonly LibraryDbContext _context;

        public StudentController(LibraryDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var ListOfStudents= _context.Students.ToList();
            return View(ListOfStudents); 
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student Stu)
        {
            _context.Students.Add(Stu);
            _context.SaveChanges();

            return View();
        }

        public IActionResult Update(int id)
        {
           Student? student= _context.Students.ToList().FirstOrDefault(x => x.Id ==id);

            return View(student);
        }

        [HttpPost]
        public IActionResult Update(Student student)
        {
            if(student.Id >0)
            {
                _context.Students.Update(student);
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
            var student= _context.Students.FirstOrDefault(x => x.Id == id);

            if(student!=null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
