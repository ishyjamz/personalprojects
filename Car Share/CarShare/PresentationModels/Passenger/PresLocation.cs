using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationModels.Passenger
{
    /// <summary>
    /// model for the locations
    /// </summary>
    public class PresLocation
    {
        public int LocationId { get; set; } 

        public string Name { get; set; }

        public int DistanceToWork { get; set; }
    }
}
