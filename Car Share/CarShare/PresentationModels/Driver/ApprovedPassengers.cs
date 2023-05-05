using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationModels.Login;

namespace PresentationModels.Driver
{
    public class ApprovedPassengers
    {
        public int DriverId { get; set; }

        [Required(ErrorMessage = "Must select a user")]
        public int PassengerId { get; set; }
        public List<PresUser> Passengers { get; set; }  
        public List<PresUser> ApprovedList { get; set; }
    }
}
