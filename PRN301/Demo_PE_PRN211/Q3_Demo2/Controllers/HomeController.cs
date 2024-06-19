using Microsoft.AspNetCore.Mvc;
using Q3_Demo2.Models;

namespace Q3_Demo2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (var con = new PE_Fall21B5Context())
            {
                var em = con.Employees.ToList();
                return View(em);
            }

        }

        public IActionResult Delete(int? id)
        {

            using (var con = new PE_Fall21B5Context())
            {
                var em = con.Employees.Find(id);
                con.Employees.Remove(em);
                con.SaveChanges();
                return RedirectToAction("Index");
            }

        }
    }
}
