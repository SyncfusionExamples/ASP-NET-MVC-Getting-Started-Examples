using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InPlaceEditorSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string[] frameWorkList = new string[] { "Andrew Fuller", "Janet Leverling", "Laura Callahan", "Margaret Hamilt", "Michael Suyama", "Nancy Davloio", "Robert King" };
            ViewBag.elementModel = new { dataSource = frameWorkList, placeholder = "Select employee", popupHeight = "200px" };
            ViewBag.url = "https://ej2services.syncfusion.com/development/web-services/api/Editor/UpdateData";
            ViewBag.textValue = "Andrew Fuller";
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