using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContextMenuSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //define the array of JSON
            List<object> menuItems = new List<object>();
            menuItems.Add(new
            {
                text = "Cut"
            });
            menuItems.Add(new
            {
                text = "Copy"
            });
            menuItems.Add(new
            {
                text = "Paste"
            });
            menuItems.Add(new
            {
                separator = true
            });
            menuItems.Add(new
            {
                text = "Font"
            });
            menuItems.Add(new
            {
                text = "Paragraph"
            });
            return View(menuItems);
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