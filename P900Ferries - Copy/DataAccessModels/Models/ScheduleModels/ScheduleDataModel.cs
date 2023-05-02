using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAccessModels.Models.ScheduleModels
{
    public class ScheduleDataModel
    {
        public int ScheduleId { get; set; }
        public int FerryId { get; set; }
        public string Description { get; set; }
        [Display(Name = "Cost Per Person")]
        public decimal CostPerPerson { get; set; }
        
        [Display(Name = "Cost Per Vehicle")]
        public decimal CostPerVehicle { get; set; }
        public byte[] RowVersion { get; set; }
        public ScheduleStopData Stops { get; set; }
        public List<ScheduleStopData> StopsGrid { get; set; }
    }
}
