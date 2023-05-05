using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationModels.Login;
using PresentationModels.Validation;

namespace PresentationModels.Passenger
{
    /// <summary>
    /// Model for the booking a journey for a passenger
    /// </summary>
    public class BookJourney
    {
        public int PassengerJourneyId { get; set; } 
        public PresUser Passenger { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DateInFuture(ErrorMessage = "Date must be in the future")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public PresLocation Location { get; set; }

        [Display(Name = "To Work")]
        [Required(ErrorMessage = "Must specify whether you want to go from or to work")]
        public bool FromToWork { get; set; }

        public List<AvailableJourneys> AvailableJourneysGrid { get; set; }
        public List<PresLocation> LocationList { get; set; }
    }
}
