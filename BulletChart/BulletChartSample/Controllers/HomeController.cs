using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BulletChartSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<BulletChartData> data = new List<BulletChartData>
            {
                new BulletChartData { value = 270, target = 250}
            };
            return View(data);
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
    public class BulletChartData
    {
        public double target;
        public double value;
    }
}