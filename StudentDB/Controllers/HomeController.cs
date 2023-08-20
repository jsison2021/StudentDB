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


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}