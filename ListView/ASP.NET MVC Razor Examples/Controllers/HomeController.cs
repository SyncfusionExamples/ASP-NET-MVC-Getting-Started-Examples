using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ListViewSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<object> data = new List<object>();
            data.Add(new { text = "Artwork", id = "01" });
            data.Add(new { text = "Abstract", id = "02" });
            data.Add(new { text = "Modern Painting", id = "03" });
            data.Add(new { text = "Ceramics", id = "04" });
            data.Add(new { text = "Animation Art", id = "05" });
            data.Add(new { text = "Oil Painting", id = "06" });
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
}