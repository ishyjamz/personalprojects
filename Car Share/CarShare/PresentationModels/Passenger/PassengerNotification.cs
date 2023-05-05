using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationModels.Passenger
{
    /// <summary>
    /// Model for the passenger notification table 
    /// </summary>
    public class PassengerNotification
    {
        public int NotificationId { get; set; }
        public ManagePassengerJourney PassengerJourney { get; set; }
        public List<PassengerNotification> NotificationGrid { get; set; }
    }
}
