using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Models.Models.FerryModels;
using Models.Models.CompanyModels;
using Models.Models.ScheduleModels;
using System.ComponentModel.DataAnnotations;

namespace Models.Models.FerryModels
{
    public class FerryViewModel
    {
        public int FerryId { get; set; }
        public int CompanyId { get; set; }

        //[Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }
        public byte[] RowVersion { get; set; }
        public CompanyViewModel Company { get; set; }
       
        public List<FerrySubModel>  FerryGrid { get; set; }
        public List<CompanyViewModel> Companies { get; set; } 
        public List<ScheduleViewModel> ScheduleGrid { get; set; }
    }
}
