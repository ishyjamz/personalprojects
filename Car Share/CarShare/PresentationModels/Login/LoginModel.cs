using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models.Models.LoginModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Must enter a username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Must enter a password")]
        public string Password { get; set; }
    }
}
