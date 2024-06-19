using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Q2.Models;

namespace Q2.Controllers
{
    public class ScheduleController : Controller
    {
        private PE_PRN_Fall2023B1Context _context = new PE_PRN_Fall2023B1Context();

        public ScheduleController()
        {
        }

        public IActionResult List(string date = null)
        {
            DateTime dateTime = DateTime.Now;
            if (date != null)
            {
                dateTime = DateTime.Parse(date);
            }
            List<Schedule> schedules = _context.Schedules
                .Include(x => x.Movie).Include(x => x.TimeSlot).Include(x => x.Room)
                .Where(x => x.StartDate <= dateTime && x.EndDate >= dateTime).ToList();

            ViewBag.Schedules = schedules;
            ViewBag.Date = dateTime.ToString("dd/MM/yyyy");
            return View();
        }
    }
}
