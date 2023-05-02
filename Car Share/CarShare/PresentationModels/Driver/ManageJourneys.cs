using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationModels.Login;
using PresentationModels.Validation;

namespace PresentationModels.Driver
{
    public class ManageJourneys
    {
        public int DriverJourneyId { get; set; }    
        public PresUser Driver { get; set; }
        public List<PresUser> Passengers { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DateInFuture(ErrorMessage = "Date must be in the future")]
        public DateTime Date { get; set; }

        
        public TimeSpan LeavingTime { get; set; }
        public int TotalSeats { get; set; }

        public int SeatsAvailable {
            get
            {
                return TotalSeats - NumberOfPassengers; 
            } 
        }
        public int NumberOfPassengers => Passengers.Count;

        public bool FromToWork { get; set; }
        public bool IsLocked { get; set; }
        
        public List<ManageJourneys> JourneyGrid { get; set; }
    }
}
