using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Models.ScheduleModels;

namespace Models.Models.BookingModels
{
    public class ChooseJourneyModel
    {
        [Display(Name = "Location From")]
        public Location LocationFrom { get; set; }

        [Display(Name = "Location To")]
        public Location LocationTo { get; set; }

        [Display(Name = "Date From")]
        [DataType(DataType.Date)]
        public DateTime DateFrom { get; set; }
        [Display(Name = "Departing After")]
        public TimeSpan DepartingAfter { get; set; }
        public List<Location> LocationList { get; set; }
        public List<JourneyInfo> JourneyGrid { get; set; }
    }
}
