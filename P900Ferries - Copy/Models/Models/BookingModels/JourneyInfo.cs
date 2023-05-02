using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.BookingModels
{
    public class JourneyInfo
    {
        public int JourneyId { get; set; }  
        public string FerryName { get; set; }   
        public string CompanyName { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime ArrivalDate { get; set; }   
        public TimeSpan ArrivalTime { get; set; }
        public TimeSpan DepartureTime { get; set; }
    }
}
