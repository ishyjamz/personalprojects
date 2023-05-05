using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAccessModels.Models.CompanyModels
{
    public class CompanyDataModel
    {
        [Display(Name = "Company Name")]
        public string Name { get; set; }
        
        public int CompanyId { get; set; }
        public byte[] RowVersion { get; set; }  
    }
}
