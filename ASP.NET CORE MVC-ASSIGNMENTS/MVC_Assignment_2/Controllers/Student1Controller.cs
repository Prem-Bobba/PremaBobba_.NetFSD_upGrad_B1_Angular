using Microsoft.AspNetCore.Mvc;
using MVC_Assignment_2.Models;

namespace MVC_Assignment_2.Controllers
{
    public class Student1Controller : Controller
    {
        public IActionResult Index()
        {
            var student = new Student
            {
                Id = 1,
                Name = "John",
                Age = 21,
                Email = "john@example.com"
            };
            return View(student);
        }
    }
}
