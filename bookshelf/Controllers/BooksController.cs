using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookshelf.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult AddBook()
        {
            return View();
        }

        public ActionResult EditBook()
        {
            return View();
        }

    }
}
