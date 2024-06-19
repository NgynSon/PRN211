using DemoQ3.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoQ3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            using (var context = new PE_PRN211_23SprB1Context())
            {
                students = context.Students.ToList();

            }
            return View(students);
        }
    }
}
