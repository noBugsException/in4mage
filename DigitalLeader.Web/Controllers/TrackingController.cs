﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigitalLeader.Web.Controllers
{
    public class TrackingController : Controller
    {
        // GET: Tracking
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GoogleAnalytics()
        {
            return View();
        }
    }
}