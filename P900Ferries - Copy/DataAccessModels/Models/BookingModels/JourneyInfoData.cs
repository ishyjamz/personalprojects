using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessModels.Models.BookingModels
{
    public class JourneyInfoData
    {
        public int JourneyId { get; set; }  
        public string FerryName { get; set; }   
        public string CompanyName { get; set; }
        public int ArrivalDay { get; set; }   
        public TimeSpan ArrivalTime { get; set; }
        public TimeSpan DepartureTime { get; set; }
    }
}
