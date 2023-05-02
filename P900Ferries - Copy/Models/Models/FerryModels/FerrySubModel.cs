using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models.Models.FerryModels
{
    public class FerrySubModel
    {
        [Display(Name = "Ferry Name")]
        public string FerryName { get; set; }
        public int FerryId { get; set; }
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; } 
        public byte[] RowVersion { get; set; }
    }
}
