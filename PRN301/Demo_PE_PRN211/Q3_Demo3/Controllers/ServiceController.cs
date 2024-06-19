using Microsoft.AspNetCore.Mvc;
using Q3_Demo3.Models;

namespace Q3_Demo3.Controllers
{
    public class ServiceController : Controller
    {
        private readonly PRN211_Spr22Context con = new PRN211_Spr22Context();
        public IActionResult Search(string? room, string? month)
        {

            var query = con.Services.AsQueryable();
            if (!string.IsNullOrEmpty(room))
            {
                query = query.Where(ok => ok.RoomTitle.Contains(room));
            }
            if (month != null)
            {
                query = query.Where(ok => ok.Month == Convert.ToInt32(month));
            }
            /*var sv = query.Select(sv => new
            {
                sv.RoomTitle,
                sv.FeeType,
                sv.Month,
                sv.Year,
                sv.Amount,
                sv.Employee
            }).ToList();*/
            List<Service> list = query.ToList();
            var getService = new ManagerEmployee
            {
                services = list,
                room = room,
                month = month
            };
            return View(getService);

        }
    }
}
