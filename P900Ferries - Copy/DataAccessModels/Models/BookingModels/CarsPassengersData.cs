using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessModels.Models.BookingModels
{
    public class CarsPassengersData
    {
        [Display(Name = "Number of Cars")]
        public int NumberOfCars { get; set; }

        [Display(Name = "Number of Passengers")]
        public int NumberOfPassengers { get; set; }
        [Display(Name = "Total Cost")]
        public decimal TotalCost { get; set; }  
    }
}
