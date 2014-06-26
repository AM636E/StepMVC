using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Translator.Code.Service.Translator;
namespace Translator.Controllers
{
    public class TranslateController : Controller
    {
        private ITranslatorService _translatorService;
        public TranslateController(ITranslatorService translatorService)
        {
            this._translatorService = translatorService;
        }

        // GET: Translate
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.SelectedLang = "";
            if (System.Web.HttpContext.Current.Request.Cookies["SelectedLang"] != null)
            {
                ViewBag.SelectedLang = System.Web.HttpContext.Current.Request.Cookies["SelectedLang"].Value;
            }
            ViewBag.Languages = this._translatorService.GetLanguages();
            return View();
        }

        [HttpPost]
        public ActionResult Index(string txtTranslateText, string translateFrom, string translateTo)
        {
            HttpCookie cookie = new HttpCookie("SelectedLang", translateTo);
            cookie.Expires = DateTime.Now.AddDays(10);
            System.Web.HttpContext.Current.Response.Cookies.Add(cookie);
            
            if (translateTo == null)
            {
                translateTo = "uk";
            }
            ViewBag.Text = _translatorService.Translate("", txtTranslateText, translateTo);
            if (Request.IsAjaxRequest())
            {
                return PartialView("_Result");
            }

            return View();
        }

        public ActionResult Countries(string countryFrom)
        {
            throw new NotImplementedException();
        }
    }
}