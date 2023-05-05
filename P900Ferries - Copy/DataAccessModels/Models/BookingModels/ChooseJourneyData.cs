using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessModels.Models.ScheduleModels;

namespace DataAccessModels.Models.BookingModels
{
    public class ChooseJourneyData
    {
        public LocationData LocationFrom { get; set; }
        public LocationData LocationTo { get; set; }
        public int DayFrom { get; set; }
        public TimeSpan DepartingAfter { get; set; }
        public List<JourneyInfoData> JourneyGrid { get; set; }
    }
}
