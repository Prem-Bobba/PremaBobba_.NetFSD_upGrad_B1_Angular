using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_2.Controllers
{
    public class Student2Controller : Controller
    {
        public IActionResult Details()
        {
            ViewBag.Name = "Prema";
            ViewData["Age"] = 23;
            return View();
        }
    }
}
