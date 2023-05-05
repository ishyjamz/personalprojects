using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models.Models.ScheduleModels
{
    public class ScheduleViewModel
    {
        public int ScheduleId { get; set; }
        public int FerryId { get; set; }
        public string Description { get; set; }
        [Display(Name = "Cost Per Person (£)")]
        [Required(ErrorMessage = "This field is required")] 
        public decimal CostPerPerson { get; set; }
        
        [Display(Name = "Cost Per Vehicle (£)")]
        [Required(ErrorMessage = "This field is required")]
        public decimal CostPerVehicle { get; set; }
        public byte[] RowVersion { get; set; }
        public ScheduleStop Stops { get; set; }
        public ScheduleStop NewStop { get; set; }
        public List<ScheduleStop> StopsGrid { get; set; }   
    }
}
