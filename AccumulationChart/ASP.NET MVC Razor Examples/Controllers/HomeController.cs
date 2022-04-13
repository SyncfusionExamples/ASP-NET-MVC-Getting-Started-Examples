using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccumulationChartSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<PieChartData> chartData = new List<PieChartData>
            {
                new PieChartData { xValue = "Chrome", yValue = 37, text = "37%", fill="#498fff"},
                new PieChartData { xValue = "UC Browser", yValue = 17, text = "17%", fill="#ffa060"},
                new PieChartData { xValue = "iPhone", yValue = 19, text = "19%", fill="#ff68b6"},
                new PieChartData { xValue = "Others", yValue = 4 , text = "4%", fill="#81e2a1"},
            };
            return View(chartData);
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
    public class PieChartData
    {
        public string xValue;
        public double yValue;
        public string text;
        public string fill;
    }
}