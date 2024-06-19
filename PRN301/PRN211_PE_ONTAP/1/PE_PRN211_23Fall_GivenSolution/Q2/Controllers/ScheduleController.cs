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
        [HttpGet]
        public IActionResult byDate()
        {
            List<TimeSlot> timeSlots = context.TimeSlots.ToList();
            ViewBag.TimeSlots = timeSlots;
            List<Room> rooms = context.Rooms.ToList();
            ViewBag.Rooms = rooms;

            // Lấy ngày hiện tại
            DateTime currentDate = DateTime.Now;

            // Retrieve schedules for the specified currentDate, including associated room and time slots
            List<Schedule> schedules = context.Schedules
                .Include(s => s.Room)
                .Include(s => s.Movie)
                .Where(s => s.StartDate.Date == currentDate.Date || s.EndDate.Date == currentDate)
                .ToList();

            return View(schedules);
        }

        [HttpPost]
        public IActionResult byDate(DateTime searchDate)
        {
            // Lấy danh sách TimeSlot và Rooms từ cơ sở dữ liệu
            List<TimeSlot> timeSlots = context.TimeSlots.ToList();
            ViewBag.TimeSlots = timeSlots;
            List<Room> rooms = context.Rooms.ToList();
            ViewBag.Rooms = rooms;

            // Lấy danh sách Schedules theo ngày tìm kiếm
            List<Schedule> schedules = context.Schedules
                .Include(s => s.Room)
                .Include(s => s.Movie)
                .Where(s => s.StartDate <= searchDate && s.EndDate >= searchDate)
                .ToList();
            ViewBag.SearchDate = searchDate;

            return View(schedules);
        }


    }
}
