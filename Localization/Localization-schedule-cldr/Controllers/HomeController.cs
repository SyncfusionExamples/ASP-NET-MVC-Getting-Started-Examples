using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScheduleLocale.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.datasource = GetScheduleData();
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

        public List<AppointmentData> GetScheduleData()
        {
            List<AppointmentData> appData = new List<AppointmentData>();
            appData.Add(new AppointmentData
            { Id = 1, Subject = "Explosion of Betelgeuse Star", StartTime = new DateTime(2022, 2, 14, 9, 30, 0), EndTime = new DateTime(2022, 2, 14, 11, 0, 0) });
            return appData;
        }

        public class AppointmentData
        {
            public int Id { get; set; }
            public string Subject { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
        }
    }
}