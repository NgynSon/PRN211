using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Q2.Models;

namespace Q2.Controllers
{
    public class ScheduleController : Controller
    {
        private PE_PRN_Fall2023B1Context _context = new PE_PRN_Fall2023B1Context();
        public IActionResult List(string date = null)
        {
            DateTime  dateTime = new DateTime(2023, 10, 24);
            if(date != null)
            {
                dateTime = DateTime.Parse(date);
            }
            /*List<Schedule> schedules = _context.Schedules
                .Include(x=> x.Movie).Include(x => x.TimeSlot).Include(x=> x.Room)
                .Where(x => x.StartDate <= dateTime && x.EndDate >= dateTime).ToList();*/
            var rooms = _context.Rooms.ToList();
            var timeSlots = _context.TimeSlots.ToList();

            var schedules = new List<List<Schedule>>();

            foreach (var room in rooms)
            {
                var roomSchedules = new List<Schedule>();
                foreach (var timeSlot in timeSlots)
                {
                    var schedule = _context.Schedules
                        .Include(x => x.Movie)
                        .Include(x => x.TimeSlot)
                        .Include(x => x.Room)
                        .FirstOrDefault(x => x.StartDate <= dateTime && x.EndDate >= dateTime && x.RoomId == room.Id && x.TimeSlotId == timeSlot.Id);

                    roomSchedules.Add(schedule);
                }
                schedules.Add(roomSchedules);
            }

            ViewBag.Date = dateTime.ToString("dd/MM/yyyy");
            ViewBag.Rooms = rooms;
            ViewBag.TimeSlots = timeSlots;
            ViewBag.Schedules = schedules;
            return View();
        }
    }
}
