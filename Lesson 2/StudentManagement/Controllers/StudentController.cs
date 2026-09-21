using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info()
        {
            ViewBag.Name = "Nguyễn Văn A";

            ViewData["Age"] = 20;

            Student student = new Student();
            student.Major = "CNTT";

            return View(student);
        }
    }
}
