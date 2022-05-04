using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MenuSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<object> menuItems = new List<object>();
            menuItems.Add(new
            {
                text = "File",
                items = new List<object>()
                    {
                        new { text = "Open" },
                        new { text = "Save" },
                        new { separator = true},
                        new { text = "Exit" }
                    }
            });
            menuItems.Add(new
            {
                text = "Edit",
                items = new List<object>()
                    {
                        new { text = "Cut" },
                        new { text = "Copy" },
                        new { text = "Paste" }
                    }
            });
            menuItems.Add(new
            {
                text = "View",
                items = new List<object>()
                    {
                        new { text = "Toolbar" },
                        new { text = "Sidebar" },
                        new { text = "Fullscreen" }
                    }
            });
            menuItems.Add(new
            {
                text = "Tools",
                items = new List<object>()
                    {
                        new { text = "Spelling & Grammar" },
                        new { text = "Customize" },
                        new { text = "Options" }
                    }
            });
            menuItems.Add(new
            {
                text = "Go"
            });
            menuItems.Add(new
            {
                text = "Help"
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