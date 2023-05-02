using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationModels.Driver;
using PresentationModels.Passenger;

namespace PresentationModels.Home
{
    public class Home
    {
        public DriverRequest DriverRequest { get; set; }
        public PassengerNotification Notification { get; set; }
    }
}
