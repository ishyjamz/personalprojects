using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using DataAccessModels.Models.FerryModels;
using DataAccessModels.Models.CompanyModels;
using System.ComponentModel.DataAnnotations;

namespace DataAccessModels.Models.FerryModels
{
    public class FerryDataModel
    {
        public int FerryId { get; set; }
        public string Name { get; set; }
        public byte[] RowVersion { get; set; }  
        public int CompanyId { get; set; }  
        public CompanyDataModel Company { get; set; }
       
        public List<ScheduleSubDataModel>  FerryGrid { get; set; }
    }
}
