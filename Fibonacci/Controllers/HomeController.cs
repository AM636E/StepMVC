using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fibonacci.Code.Services.Fibonacci;

namespace Fibonacci.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Index/

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int txtCount)
        {
            FibonacciService service = new FibonacciService();
            ViewBag.Numbers = service.GetNumbers(txtCount);
            ViewBag.Number = txtCount;
            return View();
        }

    }
}
