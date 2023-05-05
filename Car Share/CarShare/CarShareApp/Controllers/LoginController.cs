using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Models.Models.LoginModels;

namespace FerryWebApp.Controllers
{
    /// <summary>
    /// handles logic to allow user to sign in and sign out
    /// </summary>
    [AllowAnonymous]
    public class LoginController : Controller
    {
        /// <summary>
        /// returns view of login page
        /// </summary>
        /// <returns></returns>
        [Route("Login")]
        public ActionResult Login()
        {
            return View("Login");
        }
        /// <summary>
        /// Signs in the user if the username and password match 
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SignInUser(LoginModel login)
        {
            if (ModelState.IsValid)
            {
                var userStore = new UserStore<IdentityUser>();
                var userManager = new UserManager<IdentityUser>(userStore);
                var user = userManager.Find(login.Username, login.Password);
                if (user != null && user.UserName == login.Username)
                {
                    var authenticationManager = HttpContext.GetOwinContext().Authentication;
                    var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                    authenticationManager.SignIn(new AuthenticationProperties() {}, userIdentity);
                    
                    return RedirectToAction("Home", "Home");
                }
                else
                {
                    ViewBag.Text = "Could not find user with those credentials";
                    return View("Login", login);
                }
            }
            else
            {
                return RedirectToAction("Login", "Login", login);
            }
        }

        /// <summary>
        /// Signs out the current user
        /// </summary>
        /// <returns></returns>
        public ActionResult SignOut()
        {
            var authenticationManager = HttpContext.GetOwinContext().Authentication;
            authenticationManager.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}
