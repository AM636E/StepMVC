using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloEx.Controllers
{
    public class HelloController : Controller
    {
        //
        // GET: /Hello/

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string txtName)
        {
            ViewBag.Username = txtName;

            return View();
        }



    }
}
