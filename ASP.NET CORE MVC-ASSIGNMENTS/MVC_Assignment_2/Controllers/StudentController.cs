using Microsoft.AspNetCore.Mvc;

namespace MVC_Assignment_2.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "Welcome to Student Page";
        }

        public string Details()
        {
            return "Student Details Page";
        }

        public IActionResult GetStudent(int id)
        {
            return Content("Student ID is " + id);
        }
    }
}
