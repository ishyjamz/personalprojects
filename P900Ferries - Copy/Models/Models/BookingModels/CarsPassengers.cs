using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.BookingModels
{
    public class CarsPassengers
    {
        [Display(Name = "Number of Cars")]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int NumberOfCars { get; set; }

        [Display(Name = "Number of Passengers")]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive number allowed")]
        public int NumberOfPassengers { get; set; }

        [Display(Name = "Total Cost")]
        public decimal TotalCost { get; set; }  
        public decimal CostPerPerson { get; set; }
        public decimal CostPerVehicle { get; set; } 
    }
}
