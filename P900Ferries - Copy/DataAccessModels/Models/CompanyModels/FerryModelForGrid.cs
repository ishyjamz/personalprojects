﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAccessModels.Models.CompanyModels
{
    public class FerryDataForGrid
    {
        [Display(Name = "Ferry Name")]
        public string FerryName { get; set; }
        public int FerryId { get; set; }
        public int CompanyId { get; set; }  
        public byte[] RowVersion { get; set; }
    }
}