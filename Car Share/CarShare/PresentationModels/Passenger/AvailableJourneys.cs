using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using PresentationModels.Driver;

namespace PresentationModels.Passenger
{
    public class AvailableJourneys
    {
        public ManageJourneys DriverJourney { get; set; }
        public JourneyStop JourneyStop { get; set; }
        public bool Approved { get; set; }
        public TimeSpan PickUpTime { get; set; }    
        public TimeSpan ArrivalTime { get; set; }
    }
}
