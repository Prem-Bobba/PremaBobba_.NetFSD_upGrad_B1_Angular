using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_1.Controllers
{
    public class Home2Controller : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "Prema";
            ViewData["Age"] = 25;

            return View();
        }
    }
}
