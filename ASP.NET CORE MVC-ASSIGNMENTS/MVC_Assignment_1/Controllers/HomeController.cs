using Microsoft.AspNetCore.Mvc;
using MVC_Assignment_1.Models;
using System.Diagnostics;

namespace MVC_Assignment_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("Welcome to ASP.NET Core MVC");
            return View();
        }

        public IActionResult About()
        {
            return Content("This is About Page");
        }

       
        public IActionResult Contact()
        {
            return Content("Contact us at support@test.com");
        }
    }
}
