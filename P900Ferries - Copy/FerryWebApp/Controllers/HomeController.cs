﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FerryWebApp.Controllers
{
    [Authorize(Roles = "Employee")]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Home()
        {
            return View("Home");
        }
    }
}