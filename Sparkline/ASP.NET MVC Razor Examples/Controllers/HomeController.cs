using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SparklineSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(DataSource.GetData());
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
    public class DataSource
    {
        public int x;
        public string xval;
        public double yval;
        public static List<DataSource> GetData()
        {
            List<DataSource> data1 = new List<DataSource>();
            data1.Add(new DataSource() { x = 0, xval = "2005", yval = 20090440 });
            data1.Add(new DataSource() { x = 1, xval = "2006", yval = 20264080 });
            data1.Add(new DataSource() { x = 2, xval = "2007", yval = 20434180 });
            data1.Add(new DataSource() { x = 3, xval = "2008", yval = 21007310 });
            data1.Add(new DataSource() { x = 4, xval = "2009", yval = 21262640 });
            data1.Add(new DataSource() { x = 5, xval = "2010", yval = 21515750 });
            data1.Add(new DataSource() { x = 6, xval = "2011", yval = 21766710 });
            data1.Add(new DataSource() { x = 7, xval = "2012", yval = 22015580 });
            data1.Add(new DataSource() { x = 8, xval = "2013", yval = 22262500 });
            data1.Add(new DataSource() { x = 9, xval = "2014", yval = 22507620 });
            return data1;
        }
    }
}