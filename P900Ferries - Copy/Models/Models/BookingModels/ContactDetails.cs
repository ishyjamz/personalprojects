using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.BookingModels
{
    public class ContactDetails
    {
        public int BookingId { get; set; }

        [Required(ErrorMessage = "this field is required")]
        public string Name { get; set; }

        [Display(Name = "Line 1")]
        [Required(ErrorMessage = "this field is required")]
        public string Line1 { get; set; }

        [Display(Name = "Line 2")]
        public string Line2 { get; set; }

        [Required(ErrorMessage = "this field is required")]
        public string City { get; set;}

        [Required(ErrorMessage = "this field is required")]
        public string Postcode { get; set;} 
    }
}
