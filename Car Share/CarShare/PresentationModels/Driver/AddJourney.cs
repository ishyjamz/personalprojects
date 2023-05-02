using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationModels.Validation;

namespace PresentationModels.Driver
{
    public class AddJourney
    {
        [Key]
        public int DriverJourneyId { get; set; }    
        public int DriverId { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DateInFuture(ErrorMessage = "Date must be in the future")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name ="Leaving Time")]
        public TimeSpan LeavingTime { get; set; }

        [Required]
        [Display(Name = "Seats Available")]
        [Range(1, 6, ErrorMessage = "Number of seats must be between 1 and 6")]
        public int TotalSeats { get; set; }

        [Required(ErrorMessage = "Must select whether journey is either from work or to work")]
        public bool FromToWork { get; set; }

        public List<JourneyStop> StopsGrid { get; set; }  
    }
}
