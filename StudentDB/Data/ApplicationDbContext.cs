using Microsoft.AspNetCore.Mvc;

namespace StudentDB.Data
{
    public class ApplicationDbContext : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
