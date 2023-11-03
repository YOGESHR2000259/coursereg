using CourseRegMVC.DAL;
using CourseRegMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CourseRegMVC.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly MyAppDbContext _context;

        public RegistrationController(MyAppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Registrations = _context.Registrations.Include("Courses");
            return View(Registrations);
        }
        [HttpGet]
        public IActionResult Create()
        {
            LoadCourses();
            return View();
        }
        [NonAction]
        private void LoadCourses()
        {
            var courses = _context.Courses.ToList();
            ViewBag.Courses = new SelectList(courses, "Id", "Name");
        }
        [HttpPost]
        public IActionResult Create(Registration model)
        {

            _context.Registrations.Add(model);
            _context.SaveChanges();
            if(ModelState.IsValid)
            {
                TempData["SuccessMessage"] = "User added successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();

        }
        public IActionResult Success()
        {
            
            if (TempData.ContainsKey("SuccessMessage"))
            {
                ViewBag.SuccessMessage = TempData["SuccessMessage"];
            }

            return View();
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                NotFound();
            }
            LoadCourses();
            var registration = _context.Registrations.Find(id);
            return View(registration);
        }
        [HttpPost]
        public IActionResult Edit(Registration model)
        {
            ModelState.Remove("Courses");
            if (ModelState.IsValid)
            {
                _context.Registrations.Update(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                NotFound();
            }
            LoadCourses();
            var registration = _context.Registrations.Find(id);
            return View(registration);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(Registration model)
        {
            _context.Registrations.Remove(model);
            _context.SaveChanges();
            
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id != null)
            {
                NotFound();
            }
            LoadCourses();
            var registration = _context.Registrations.Find(id);
            return View(registration);
        }

    }
}
