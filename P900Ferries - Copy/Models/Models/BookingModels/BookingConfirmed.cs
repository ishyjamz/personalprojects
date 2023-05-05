using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.BookingModels
{
    public class BookingConfirmed
    {
        public int BookingId { get; set; }
        public string UserId { get; set; }
        
        public string BookingReference { get; set; }    
        public int Cars { get; set; }
        public int Passengers { get; set; }
        public decimal Cost { get; set; }   
        public string CompanyName { get; set; } 
        public string FerryName { get; set; }
        public DateTime DepartureDate { get; set; }
        public string DepartureLocation { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string ArrivalLocation { get; set;}
    }
}
