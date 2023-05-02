using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessModels.Models.FerryModels
{
    public class ScheduleSubDataModel
    {
        public string FerryName { get; set; }
        public int FerryId { get; set; }
        public string CompanyName { get; set; } 
        //public byte[] RowVersion { get; set; }
    }
}
