using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationModels.Passenger;

namespace PresentationModels.Driver
{
    public class Stops
    {
        public int DriverId { get; set; }   

        [Required(ErrorMessage ="Location is required")]
        public PresLocation StopLocation { get; set; }

        [Required(ErrorMessage = "Time from home is required")]
        [Display(Name = "Time From Home (mins)")]
        [Range(1, Int32.MaxValue, ErrorMessage = "Time from home must be above zero")]
        public int TimeFromHome { get; set; }
        
        public List<PresLocation> LocationList { get; set; }
        public List<Stops> StopsGrid { get; set; }
    }
}
