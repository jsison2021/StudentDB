using Microsoft.AspNetCore.Mvc;

namespace StudentDB.Models
{
    public class Students : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
