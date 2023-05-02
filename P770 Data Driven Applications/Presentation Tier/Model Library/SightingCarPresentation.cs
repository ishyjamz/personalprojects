using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Library
{
    /// <summary>
    /// Presentation Layer model for sightings of a car
    /// </summary>
    public class SightingCarPresentation
    {
        public int SightingID { get; set; }
        public int CarID { get; set; }
        public string RegNumber { get; set; }
        public int CameraID { get; set; }
        public DateTime SightingTime { get; set; }  
        public byte? SecondsAfterRedLight { get; set; }
        public byte? Speed { get; set; }
        public DateTime? DateIssued { get; set; }
        public DateTime? DatePaid { get; set; }  
    }
}
