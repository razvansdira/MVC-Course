﻿using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class HomeController : Controller
    {
        public double Average()
        {
            var list = new List<int> { 1, 3, 7 };
            //return list.Average();
            int sum = 0;
            foreach (int x in list) 
                sum += x;
            return sum / list.Count;
        }

        public ActionResult HelloWorld()
        {
            return Content("Hey");
        }

        public ActionResult RedirectToRoute()
        {
            return Content("");
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Author = "Razvan";

            var model = new AboutModel();
            model.Message = "Hello";
            model.Author = "Alex";
            return View(model);

            // return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}