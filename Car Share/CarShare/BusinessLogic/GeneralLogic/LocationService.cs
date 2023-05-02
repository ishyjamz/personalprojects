using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityDataAccessModels;
using PresentationModels.Passenger;

namespace BusinessLogic.GeneralLogic
{
    /// <summary>
    /// Contains logic for the locations
    /// </summary>
    public class LocationService
    {
        /// <summary>
        /// lists all of the available locations
        /// </summary>
        /// <returns></returns>
        public List<PresLocation> List()
        {
            using (var context = new CarShareEntities())
            {
                var locationList = context.Locations.Select(c =>
                new PresLocation
                {
                    LocationId = c.LocationId,
                    Name = c.Name
                });
                return locationList.OrderBy(c => c.Name).ToList();
            }
        }
    }
}
