using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using StudentDB.Data;
using StudentDB.Models;
using System.Diagnostics;

namespace StudentDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _db;

        public HomeController(ILogger<HomeController> logger, AppDbContext db)
        {
            _logger = logger;

            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Student> objStudentList = _db.Students;
            return View(objStudentList);
        }

        public IActionResult Create()
        {
          
            return View();
        }
        //Edit
        public IActionResult Edit(int? id)
        {
          
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var studentFromDb = _db.Students.Find(id);

            if (studentFromDb == null)
            {
                return NotFound();
            }
            return View(studentFromDb);
        }
    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student obj)
        {

            if (ModelState.IsValid)
            {
                _db.Students.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Student Profile Updated!";
                return RedirectToAction("Index");
            }

            return View(obj);

        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student obj)
        {

            if (ModelState.IsValid)
            {
                _db.Students.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Student Profile Created!";
                return RedirectToAction("Index");
            }

            return View(obj);
            
        }

        //Delete
        public IActionResult Delete(int? id)
        {

           
            var studentFromDb = _db.Students.Find(id);

            if (studentFromDb == null)
            {
                return NotFound();
            }
            return View(studentFromDb);
        }
        public IActionResult DeletePost(int? id)
        {
         
            var deleteFromDb = _db.Students.Find(id);

            if (deleteFromDb == null)
            {
                return NotFound();
            }
            _db.Students.Remove(deleteFromDb);
                _db.SaveChanges();
                TempData["success"] = "Student Profile Deleted!";
                return RedirectToAction("Index");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}