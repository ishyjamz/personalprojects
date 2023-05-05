using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessModels.Models.ScheduleModels
{
    public class ScheduleSubDataModel
    {
        public int ScheduleId { get; set; } 
        public int FerryId { get; set; }
        public string Description { get; set; }
        [Display(Name = "Cost Per Person (£)")]
        public decimal CostPerPerson { get; set; }

        [Display(Name = "Cost Per Vehicle (£)")]
        public decimal CostPerVehicle { get; set; }
    }
}

