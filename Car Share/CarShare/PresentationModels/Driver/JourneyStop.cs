using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationModels.Passenger;
using System.Xml.Linq;

namespace PresentationModels.Driver
{
    public class JourneyStop
    {
        public int JourneyStopId { get; set; }

        public AddJourney DriverJourney { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [Index(IsUnique = true)]
        public PresLocation Location { get; set; }

        public int TimeFromHome { get; set; }   
    }
}
