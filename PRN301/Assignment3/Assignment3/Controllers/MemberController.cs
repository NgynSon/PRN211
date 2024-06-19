using Assignment3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Assignment3.Controllers
{
    public class MemberController : Controller
    {
        private readonly FStoreContext context;

        public bool IsPostBack { get; private set; }

        public MemberController()
        {
            context = new FStoreContext();
        }

        public ActionResult Index(string id)
        {
            // var model = context.Products.ToList();
            var model = from member in context.Members select member;
            if (!string.IsNullOrEmpty(id))
            {
                              
                {
                    model = model.Where(x => (x.MemberId).ToString().Contains(id));
                }

            }

            return View(model);
        }


        // GET: ProductController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var member = context.Members.FirstOrDefault(m => m.MemberId == id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Member member)
        {
            if (ModelState.IsValid)
            {
                context.Members.Add(member);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
                ;
            }
            var member = context.Members.Find(id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, Member member)
        {
            if (id != member.MemberId)
            {
                return NotFound();

            }
            if (ModelState.IsValid)
            {
                context.Update(member);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int? id)
        {
            var member = context.Members.Find(id);
            context.Members.Remove(member);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public IActionResult Refresh()
        {
            return RedirectToAction(nameof(Index));
        }

        public ActionResult OrderDetails(int id)
        {
            if (id == null)
            {
                return NotFound();
                ;
            }
            var orderDetail = context.OrderDetails
        .Include(od => od.Order)
        .ThenInclude(o => o.Member)
        .FirstOrDefault(od => od.OrderId == id);
            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult OrderDetails(int? id, OrderDetail orderDetail)
        {
            if (id != orderDetail.OrderId && id != orderDetail.ProductId)
            {
                return NotFound();

            }
            if (ModelState.IsValid)
            {
                context.Update(orderDetail);
                context.SaveChanges();
                return RedirectToAction(nameof(OrderDetails));
            }
            return View(orderDetail);
        }



    }

}