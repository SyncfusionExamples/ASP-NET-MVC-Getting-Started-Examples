using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimePicker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.minVal = new DateTime(2022, 05, 07, 1, 00, 00);
            ViewBag.maxVal = new DateTime(2022, 05, 07, 11, 00, 00);
            ViewBag.value = new DateTime(2022, 05, 07, 4, 00, 00);
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