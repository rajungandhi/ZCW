﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZCW.Controllers
{
    public class TimesheetController : Controller
    {
        // GET: Timesheet
        public ActionResult Index()
        {
            return View();
        }
        private void getWeeklyTimesheet()
        {
            //Changes in Branch 15.1
        }
    }
}