using bookshelf.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookshelf.Controllers
{
    public class MemberController : Controller
    {
        UyelerContext uyelerContext = new UyelerContext();
        public IActionResult Index()
        {
            var model = uyelerContext.Members.ToList();

            return View(model);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Member member)
        {
            var model = uyelerContext.Members.Add(member);
            uyelerContext.SaveChanges();
            return RedirectToAction("Index","Member");
        }

        public IActionResult Delete(int id)
        {
            var silinecek = uyelerContext.Members.Find(id);
            var model = uyelerContext.Members.Remove(silinecek);
            uyelerContext.SaveChanges();
            return RedirectToAction("Index", "Member");
        }

    }
}
