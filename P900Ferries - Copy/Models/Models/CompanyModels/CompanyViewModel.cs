using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Models.Models.FerryModels;

namespace Models.Models.CompanyModels
{
    public class CompanyViewModel
    {
        [Display(Name = "Company Name")]
        //[Required(ErrorMessage = "This field is required")]
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public List<FerryModelForGrid> FerryGrid { get; set; }
        public List<CompanyViewModel> CompanyGrid { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
