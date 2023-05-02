using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models.Models.CompanyModels
{
    public class FerryModelForGrid
    {
        [Display(Name = "Ferry Name")]
        public string FerryName { get; set; }
        public int FerryId { get; set; }
        public int CompanyId { get; set; }  
        public byte[] RowVersion { get; set; }
    }
}
