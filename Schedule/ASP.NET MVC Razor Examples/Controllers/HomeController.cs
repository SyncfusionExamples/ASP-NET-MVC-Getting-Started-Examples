﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScheduleSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(GetScheduleData());
        }
        public List<AppointmentData> GetScheduleData()
        {
            List<AppointmentData> appData = new List<AppointmentData>();
            appData.Add(new AppointmentData
            { Id = 1, Subject = "Explosion of Betelgeuse Star", StartTime = new DateTime(2022, 2, 11, 9, 30, 0), EndTime = new DateTime(2022, 2, 11, 11, 0, 0) });
            appData.Add(new AppointmentData
            { Id = 2, Subject = "Thule Air Crash Report", StartTime = new DateTime(2022, 2, 12, 12, 0, 0), EndTime = new DateTime(2022, 2, 12, 14, 0, 0) });
            appData.Add(new AppointmentData
            { Id = 3, Subject = "Blue Moon Eclipse", StartTime = new DateTime(2022, 2, 13, 9, 30, 0), EndTime = new DateTime(2022, 2, 13, 11, 0, 0) });
            appData.Add(new AppointmentData
            { Id = 4, Subject = "Meteor Showers in 2018", StartTime = new DateTime(2022, 2, 14, 13, 0, 0), EndTime = new DateTime(2022, 2, 14, 14, 30, 0) });
            appData.Add(new AppointmentData
            { Id = 5, Subject = "Milky Way as Melting pot", StartTime = new DateTime(2022, 2, 15, 12, 0, 0), EndTime = new DateTime(2022, 2, 15, 14, 0, 0) });
            return appData;
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
    public class AppointmentData
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}