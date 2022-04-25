using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DashboardLayoutSample.Controllers
{
    public class HomeController : Controller
    {
        public class spacingModel
        {
            public double[] cellSpacing { get; set; }
        }
        public ActionResult Index()
        {
            spacingModel modelValue = new spacingModel();
            modelValue.cellSpacing = new double[] { 10, 10 };
            return View(modelValue);
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