using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Q2.Models;

namespace Q2.Controllers
{
    public class ScheduleController : Controller
    {
        public IActionResult List()
        {
            using(PE_PRN_Fall2023B1Context ctx = new PE_PRN_Fall2023B1Context())
            {
                ViewBag.rooms = ctx.Rooms.ToList();
                ViewBag.timeslots = ctx.TimeSlots.ToList();
            }
            return View();
        }

        [HttpPost]
        public IActionResult List(DateTime date)
        {
            using (PE_PRN_Fall2023B1Context ctx = new PE_PRN_Fall2023B1Context())
            {
                ViewBag.rooms = ctx.Rooms.ToList();
                ViewBag.timeslots = ctx.TimeSlots.ToList();
                List<Schedule> schedules = ctx.Schedules.Include(sc => sc.Movie)
                                                        .Where(sc => sc.StartDate <= date && sc.EndDate >= date).ToList();
                ViewBag.schedule = schedules;
                ViewBag.date = date;
            }
            return View();
        }
    }
}
