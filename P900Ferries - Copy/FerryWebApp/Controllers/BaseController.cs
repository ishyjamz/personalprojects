using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FerryWebApp.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        protected override OnException(Exception ex)
        {
            RedirectToAction("Index", "Home");
        }
    }
}
