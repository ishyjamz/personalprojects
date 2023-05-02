using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityDataAccessModels;
using PresentationModels.Driver;
using PresentationModels.Passenger;

namespace BusinessLogic.DriverLogic
{
    /// <summary>
    /// contains business logic for managing stops a driver will make
    /// </summary>
    public class DriverStopService
    {
        /// <summary>
        /// performs a search for all the stops belonging to a driver
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public List<Stops> List(int userID)
        {
            using (var context = new CarShareEntities())
            {
                var stopsList = context.DriverStops.Select(c =>
                new Stops
                {
                    DriverId = c.UserId,
                    StopLocation = new PresLocation
                    {
                        LocationId = c.Location.LocationId,
                        Name = c.Location.Name,
                        DistanceToWork= c.Location.DistanceToWork,
                    },
                    TimeFromHome = c.TimeFromHome
                }).Where( s => s.DriverId == userID).OrderBy(s => s.TimeFromHome).ToList();    
                return stopsList;
            }
        }

        /// <summary>
        /// Adds a new stop that a driver is willing to make
        /// </summary>
        /// <param name="stop"></param>
        public string Create(Stops stop)
        {
            using (var context = new CarShareEntities())
            {
                var driverStop = new DriverStop()
                {
                    LocationId = stop.StopLocation.LocationId,
                    UserId = stop.DriverId,
                    TimeFromHome = stop.TimeFromHome
                };
                if (!context.DriverStops
                    .Where(ds => ds.User.UserId == stop.DriverId)
                    .Any(ds => ds.Location.LocationId == stop.StopLocation.LocationId))
                {
                    context.DriverStops.Add(driverStop);
                    context.SaveChanges();
                    return "Stop added successfully";
                }
                else
                {
                    return "Cannot insert two stops with same location";
                }
            }
        }

        /// <summary>
        /// Deletes a stop that a driver is willing to make
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int userId, int id)
        {
            using (var context = new CarShareEntities())
            {
                var stop = context.DriverStops.Where(ds => ds.User.UserId == userId)
                    .SingleOrDefault(ds => ds.Location.LocationId == id);
                context.DriverStops.Remove(stop);
                context.SaveChanges();
            }
        }
    }
}
