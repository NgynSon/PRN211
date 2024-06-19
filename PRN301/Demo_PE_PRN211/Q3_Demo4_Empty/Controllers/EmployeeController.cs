using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Q3_Demo4_Empty.Models;
using System.Net.WebSockets;

namespace Q3_Demo4_Empty.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly PRN_Sum22_B1Context con = new PRN_Sum22_B1Context();

        public IActionResult List(int? de)
        {
            /*List<Employee> employees = new List<Employee>();*/
            var query = con.Employees.Include(e => e.Department).AsQueryable();

            if (de != null)
            {
                query = query.Where(e => e.DepartmentId == de);
            }


            var e = query.ToList();
            ViewBag.De = de;
            return View(e);
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee? employee)
        {
            if (employee != null)
            {
                con.Employees.Add(employee);
                con.SaveChanges();
            }
            ViewBag.Message = "Thanh cong roi";
            return View();
        }

        public IActionResult Edit(int? id)
        {
            Employee e = new Employee();
            if (id != null)
            {

                e = con.Employees.FirstOrDefault(e => e.EmployeeId == id);
            }


            return View(e);
        }

        [HttpPost]
        public IActionResult Edit(Employee? e)
        {
            if (e != null)
            {
                con.Employees.Update(e);
                con.SaveChanges();
            }
            ViewBag.Message = "Thành cong cái chóa gì";
            return View(e);

        }

        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                List<Order> orders = new List<Order>();
                var e = con.Employees.FirstOrDefault(e => e.EmployeeId == id);
                orders = con.Orders.Where(o => o.EmployeeId == id).ToList();
                foreach (var i in orders)
                {
                    con.Orders.Remove(i);
                    con.SaveChanges();
                }

                con.Employees.Remove(e);
                con.SaveChanges();
            }

            return RedirectToAction("List");
        }
    }
}
