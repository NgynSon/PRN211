using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Q2.Models;

namespace Q2.Controllers
{
    public class ScheduleController : Controller
    {
        public PE_PRN_Fall2023B1Context context = new PE_PRN_Fall2023B1Context();

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult schedule()
        {
            List<TimeSlot> timeSlots = context.TimeSlots.ToList();
            ViewBag.TimeSlots = timeSlots;
            List<Room> rooms = context.Rooms.ToList();
            ViewBag.Rooms = rooms;

            DateTime currentDate = DateTime.Now;

            List<Schedule> schedules = context.Schedules
                .Include(x => x.Room)
                .Include(x => x.Movie)
                .Where(x => x.StartDate <= currentDate && x.EndDate >= currentDate)
                .ToList();
            
            /*var list = (from schedule in context.Schedules
                       join room in context.Rooms
                       on schedule.RoomId equals room.Id
                       join movie in context.Movies
                       on schedule.MovieId equals movie.Id
                       where schedule.StartDate >= currentDate && schedule.EndDate <= currentDate
                       select new
                       {
                           Id = schedule.Id,

                       }).ToList();*/

            return View(schedules);
        }

        [HttpPost]
        public IActionResult schedule(DateTime searchDate)
        {
            List<TimeSlot> timeSlots = context.TimeSlots.ToList();
            ViewBag.TimeSlots = timeSlots;
            List<Room> rooms = context.Rooms.ToList();
            ViewBag.Rooms = rooms;



            List<Schedule> schedules = context.Schedules
                .Include(x => x.Room)
                .Include(x => x.Movie)
                .Where(x => x.StartDate <= searchDate && x.EndDate >= searchDate)
                .ToList();
            
            ViewBag.schedule = schedules;
            ViewBag.SearchDate = searchDate;
            return View(schedules);
        }
    }
}
