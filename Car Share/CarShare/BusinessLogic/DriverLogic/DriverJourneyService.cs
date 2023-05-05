using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using EntityDataAccessModels;
using PresentationModels.Driver;
using PresentationModels.Passenger;
using PresentationModels.Login;

namespace BusinessLogic.DriverLogic
{
    /// <summary>
    /// Contains business logic for managing journeys that a driver makes
    /// </summary>
    public class DriverJourneyService
    {
        /// <summary>
        /// Locks a driver's journey so a passenger cannot find it in their search 
        /// </summary>
        /// <param name="driverJourneyId"></param>
        public void LockJourney(int driverJourneyId)
        {
            using (var context = new CarShareEntities())
            {
                var driverJourney = context.DriverJourneys.FirstOrDefault(c => c.DriverJourneyId == driverJourneyId);
                driverJourney.IsLocked = true;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Unlocks a journey so a passenger can find it in their search
        /// </summary>
        /// <param name="driverJourneyId"></param>
        public void UnlockJourney(int driverJourneyId)
        {
            using (var context = new CarShareEntities())
            {
                var driverJourney = context.DriverJourneys.FirstOrDefault(c => c.DriverJourneyId == driverJourneyId);
                driverJourney.IsLocked = false;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Lists all the passengers of a journey that have been accepted onto the journey
        /// </summary>
        /// <param name="driverJourneyId"></param>
        /// <returns></returns>
        public List<PresUser> ListApprovedPassengersForJourney(int driverJourneyId)
        {
            using (var context = new CarShareEntities())
            {
                var passengersList = context.PassengerJourneys
                    .Where(c => c.JourneyStop.DriverJourney.DriverJourneyId == driverJourneyId)
                    .Where(c => c.PassengerJourneyStatus.StatusId == 1)
                    .Select(c => new PresUser
                    {
                        UserId = c.User.UserId,
                        Name = c.User.Name
                    }).ToList();
                return passengersList;
            }
        }

        /// <summary>
        /// Performs a search for all of the journeys belonging to a driver
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public List<ManageJourneys> List(int userID)
        {
            using (var context = new CarShareEntities())
            {
                var journeysList = context.DriverJourneys.Select(c =>
                new ManageJourneys
                {
                    DriverJourneyId = c.DriverJourneyId,
                    Date = c.Date,
                    FromToWork = c.FromToWork,
                    LeavingTime = c.LeavingTime,
                    TotalSeats = c.SeatsAvailable,
                    Driver = new PresUser
                    {
                        UserId = c.User.UserId,
                        Name = c.User.Name,
                    },
                    IsLocked = c.IsLocked
                }).Where(s => s.Driver.UserId == userID).OrderBy(s => s.Date).ToList();
                return journeysList;
            }
        }

        /// <summary>
        /// Creates a new journey that a passenger can book onto
        /// </summary>
        /// <param name="journey"></param>
        public void Create(AddJourney journey)
        {
            using (var context = new CarShareEntities())
            {
                var driverJourney = new DriverJourney()
                {
                    Date = journey.Date,
                    DriverId = journey.DriverId,
                    SeatsAvailable = journey.TotalSeats,
                    FromToWork = journey.FromToWork,
                    LeavingTime = journey.LeavingTime,
                    IsLocked = false
                };
                var newJourney = context.DriverJourneys.Add(driverJourney);

                foreach (var item in journey.StopsGrid)
                {
                    var journeyStop = new EntityDataAccessModels.JourneyStop()
                    {
                        TimeFromHome = item.TimeFromHome,
                        DriverJourneyId = newJourney.DriverJourneyId,
                        LocationId = item.Location.LocationId
                    };
                    context.JourneyStops.Add(journeyStop);
                }
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Lists all the journeyStops for a driver
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public List<PresentationModels.Driver.JourneyStop> ListStops(int userID)
        {
            using (var context = new CarShareEntities())
            {
                var journeyStopsList = context.DriverStops.Select(c =>
                new PresentationModels.Driver.JourneyStop
                {
                    DriverJourney = new AddJourney
                    {
                        DriverId = c.UserId
                    },
                    TimeFromHome = c.TimeFromHome,
                    Location = new PresLocation
                    {
                        LocationId = c.Location.LocationId,
                        Name = c.Location.Name
                    }
                }).Where(s => s.DriverJourney.DriverId == userID).OrderBy(s => s.TimeFromHome).ToList();
                return journeyStopsList;
            }
        }

        /// <summary>
        /// Lists all of the approved passengers for a user
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public List<PresUser> ListApprovedPassengers(int userID)
        {
            using (var context = new CarShareEntities())
            {
                User driver = context.Users.FirstOrDefault(d => d.UserId == userID);
                var passengerList = driver.Passenger.Select(c => new PresUser
                {
                    UserId = c.UserId,
                    Name = c.Name
                }).OrderBy(c => c.Name).ToList();
                return passengerList;
            }
        }

        /// <summary>
        /// Adds a user to the logged in users approved passenger list
        /// </summary>
        /// <param name="driverId"></param>
        /// <param name="passengerId"></param>
        public void ApprovePassenger(int driverId, int passengerId)
        {
            using (var context = new CarShareEntities())
            {
                //Use single instead if no exception expected
                User driver = context.Users.FirstOrDefault(u => u.UserId == driverId);
                User passenger = context.Users.FirstOrDefault(u => u.UserId == passengerId);
                driver.Passenger.Add(passenger);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Removes passenger from driver's approved list
        /// </summary>
        /// <param name="driverId"></param>
        /// <param name="passengerId"></param>
        public void RemovePassenger(int driverId, int passengerId)
        {
            using (var context = new CarShareEntities())
            {
                User driver = context.Users.FirstOrDefault(u => u.UserId == driverId);
                User passenger = context.Users.FirstOrDefault(u => u.UserId == passengerId);
                driver.Passenger.Remove(passenger);
                context.SaveChanges();
            }
        }
    }
}
