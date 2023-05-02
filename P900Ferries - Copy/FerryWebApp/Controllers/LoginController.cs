using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Models.Models.LoginModels;

namespace FerryWebApp.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [Route("Login")]
        public ActionResult Login()
        {
           return View("Login");
        }
        [HttpPost]
        public ActionResult SignInUser(LoginViewmodel login)
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

                    authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);
                    if (user.Roles.FirstOrDefault().RoleId == "5a9b80af-816e-4019-9a76-acb6d37fa8f0")
                    {
                        return RedirectToAction("Home", "Home");
                    }
                    else
                    {
                        return RedirectToAction("JourneyPicker", "Booking");
                    }
                    
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
    }
}
