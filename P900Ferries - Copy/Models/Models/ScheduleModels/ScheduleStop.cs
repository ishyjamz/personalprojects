using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq;
using System.Web;

namespace Models.Models.ScheduleModels
{
    public class ScheduleStop
    {
        public int ScheduleStopId { get; set; }
        public int ScheduleId { get; set; }
        [Required]
        public int LocationId { get; set; }

        [Display(Name = "Departure Day")]
        [Required (ErrorMessage = "Must select departure day")]
        public DayOfTheWeek DepartureDay { get; set; }

        [Display(Name = "Departure Time")]
        [Required(ErrorMessage = "Must select departure time")]
        public TimeSpan DepartureTime { get; set; }

        [Display(Name = "Arrival Day")]
        [Required(ErrorMessage = "Must select arrival day")]
        public DayOfTheWeek ArrivalDay { get; set; }

        [Required(ErrorMessage = "Must select arrival time")]
        [Display(Name = "Arrival Time")]
        public TimeSpan ArrivalTime { get; set;}
        public Location Location { get; set; }
        public List<DayOfTheWeek> DepartureDayList { get; set; }
        public List<DayOfTheWeek> ArrivalDayList { get; set; }
        public List<Location> LocationList { get; set; }
    }
}
