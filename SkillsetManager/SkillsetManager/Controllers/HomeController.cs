﻿using SkillsetManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkillsetManager.Controllers
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

        public ActionResult Form()
        {
            ViewBag.Message = "This is a submit Form.";

            return View();
        }

        [HttpPost]
        public ActionResult Form(FormModel formdata)
        {
            ViewBag.Message = "This is a submit Form.";

            string name = formdata.Name;
            string dob = formdata.Birthdate;

            if (!ModelState.IsValid)
            {
                return View(formdata);
            }
            return View("Error");
        }
    }
}