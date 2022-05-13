using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DialogSample.Controllers
{
    public class HomeController : Controller
    {
        public class ButtonModel
        {
            public string content { get; set; }
            public bool isPrimary { get; set; }
            public string cssClass { get; set; }

        }
        public ActionResult Index()
        {
            ViewBag.DialogButtons1 = new ButtonModel() { isPrimary = true, cssClass = "e-flat", content = "OK" };
            ViewBag.DialogButtons2 = new ButtonModel() { content = "Cancel", cssClass = "e-flat" };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}