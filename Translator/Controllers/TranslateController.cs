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
            ViewBag.Languages = this._translatorService.GetLanguages();
            return View();
        }

        [HttpPost]
        public ActionResult Index(string text)
        {
            ViewBag.Text = _translatorService.Translate("", text, "uk");
            if(Request.IsAjaxRequest())
            {
                return PartialView("_Result");
            }

            return View();
        }
    }
}