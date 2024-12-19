using Microsoft.AspNetCore.Mvc;
using mvcapp.Models;

namespace mvcapp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "Anish"
            };
            return View(student);
        }
    }
}
