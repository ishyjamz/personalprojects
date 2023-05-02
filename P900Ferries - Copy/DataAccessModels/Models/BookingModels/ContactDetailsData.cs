using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessModels.Models.BookingModels
{
    public class ContactDetailsData
    {
        public int BookingId { get; set; }  
        public string Name { get; set; }

        [Display(Name = "Line 1")]
        public string Line1 { get; set; }

        [Display(Name = "Line 2")]
        public string Line2 { get; set; }

        public string City { get; set;}

        public string Postcode { get; set;} 
    }
}
