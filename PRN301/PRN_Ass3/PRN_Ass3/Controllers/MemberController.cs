using Microsoft.AspNetCore.Mvc;
using PRN_Ass3.Models;
using System.Diagnostics;

namespace PRN_Ass3.Controllers
{
    public class MemberController : Controller
    {
        private readonly PRN_As3Context context = new PRN_As3Context();
        // GET: ProductController
        public ActionResult Index(string name, decimal? to, decimal? from)
        {
            // var model = context.Products.ToList();
            var model = from member in context.Members select member;
            if (!string.IsNullOrEmpty(name))
            {
                if (to != null && from != null)
                {
                    model = model.Where(x => x.Email.Contains(name) && x.MemberId >= to && x.MemberId <= from);
                }
                else
                {
                    model = model.Where(x => x.Email.Contains(name));
                }

            }
            else
            {
                if (to != null && from != null)
                {
                    model = model.Where(x => x.Email.Contains(name) && x.MemberId >= to && x.MemberId <= from);
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
    }
}