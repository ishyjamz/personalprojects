using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using PresentationModels.Login;
using PresentationModels.Passenger;

namespace PresentationModels.Driver
{
    public class DriverRequest
    {
        public DateTime Date { get; set; }
        public PresUser Passenger { get; set; }
        public JourneyStop Stop { get; set; }
        public List<DriverRequest> DriverRequests { get; set; }

        public BookJourney Journey { get; set; }
    }
}
