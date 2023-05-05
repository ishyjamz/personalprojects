using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.BookingModels
{
    public class BookingSummary
    {
        [Display(Name = "Departure Location:")]
        public string DepartureLocation { get; set; }

        [Display(Name = "Destination:")]
        public string ArrivalLocation { get; set; }

        [Display(Name = "Departure Date:")]
        public DateTime DateFrom { get; set; }

        [Display(Name = "Departure Time:")]
        public TimeSpan DepartTime { get; set; }

        [Display(Name = "Arrival Date:")]
        public DateTime ArrivalDate { get; set; }

        [Display(Name = "Arrival Time:")]
        public TimeSpan ArrivalTime { get; set; }

        [Display(Name = "Number of Cars:")]
        public int NumberOfCars { get; set; }

        [Display(Name = "Number of Passengers:")]
        public int NumberOfPassengers { get; set; }

        [Display(Name = "Person Name:")]
        public string PersonName { get; set; }

        [Display(Name = "Line 1:")]
        public string Line1 { get; set; }

        [Display(Name = "Line 2:")]
        public string Line2 { get; set; }

        [Display(Name = "City:")]
        public string City { get; set; }

        [Display(Name = "Postcode:")]
        public string Postcode { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Total Cost:")]
        public decimal TotalCost { get; set; }
    }
}
