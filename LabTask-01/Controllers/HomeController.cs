﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTask_01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult Education()
        {
            ViewBag.Message = "Your Education Information page.";

            return View();
        }
        public ActionResult Project()
        {
            ViewBag.Message = "Your Project Details page.";

            return View();
        }
        public ActionResult Reference()
        {
            ViewBag.Message = "Reference page.";

            return View();
        }
        public ActionResult Personal_info()
        {
            ViewBag.Message = "Your Personal Information page.";

            return View();
        }
    }
}