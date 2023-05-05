using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Library
{
    /// <summary>
    /// Presentation Layer model for Cameras
    /// </summary>
    public class CameraPresentation
    {
        public int CameraId { get; set; }
        public string RoadName { get; set; }
        public string RoadNumber { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public Nullable<int> AddressId { get; set; }
        public string Line1 { get; set; }
        public string CameraType { get; set; }
        public byte? SpeedThreshold { get; set; }    
        public byte? TimeThreshold { get; set; }
    }
}
