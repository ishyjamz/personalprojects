using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic.GeneralLogic;
using Microsoft.AspNet.Identity;
using PresentationModels.Login;

namespace CarShareApp.Controllers
{
    public abstract class BaseController : Controller
    {
        private PresUser _ApplicationUser;
        public UserService _User = new UserService();

        /// <summary>
        /// Retrieves user from its aspnetuserid
        /// </summary>
        protected PresUser ApplicationUser
        {
            get
            {
                if (_ApplicationUser == null)
                {
                    _ApplicationUser = _User.Get(User.Identity.GetUserId());
                }
                return _ApplicationUser;
            }
        }

        /// <summary>
        /// global error handling for all pages
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.ExceptionHandled)
            {
                return;
            }
            filterContext.Result = new ViewResult
            {
                ViewName = "~/Views/Shared/Error.cshtml"
            };
            filterContext.ExceptionHandled = true;
        }
    }
}
