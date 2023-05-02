using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessModels.Models.ScheduleModels
{
    public class ScheduleStopData
    {
        public int ScheduleStopId { get; set; }
        public int ScheduleId { get; set; } 
        public int LocationId { get; set; }
        public int DepartureDay { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public int ArrivalDay { get; set; }
        public TimeSpan ArrivalTime { get; set;}
        public LocationData Location { get; set; }
        public string ConvertDayIdToDay(int dayId)
        {
            string[] days = new string[] {"Monday", "Tuesday", "Wednesday", 
                "Thursday", "Friday", "Saturday", "Sunday"};
            return days[dayId];

        }
        public string DepartureDayName => ConvertDayIdToDay(DepartureDay);
        public string ArrivalDayName => ConvertDayIdToDay(ArrivalDay);
    }
}
