using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloEx.Controllers
{
    public class FibonacciController : Controller
    {
        //
        // GET: /Fibonacci/

        public ActionResult Index()
        {
            return View();
        }

    }
}
