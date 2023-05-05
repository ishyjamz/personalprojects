using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationModels.Driver;
using PresentationModels.Login;

namespace PresentationModels.Passenger
{
    /// <summary>
    /// Model for the booking a journey for a passenger
    /// </summary>
    public class PresPassengerJourney
    {
        public int PassengerJourneyId { get; set; } 
        public JourneyStop JourneyStop { get; set; }
        public PassengerJourneyStatus Status { get; set; }
        public PresUser Passenger { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
