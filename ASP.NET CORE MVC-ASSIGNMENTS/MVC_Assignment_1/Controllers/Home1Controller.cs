using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_1.Controllers
{
    public class Home1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
