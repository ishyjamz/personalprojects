using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationModels.Driver;
using PresentationModels.Login;

namespace PresentationModels.Passenger
{
    public class ManagePassengerJourney
    {
        public int PassengerJourneyId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan PickUpTime { get; set; }
        public PresLocation Location { get; set; }
        public PresUser Driver { get; set; }
        public PassengerJourneyStatus Status { get; set; }
        public List<ManagePassengerJourney> JourneyGrid { get; set; }   
        public JourneyStop JourneyStop { get; set; }
    }
}
