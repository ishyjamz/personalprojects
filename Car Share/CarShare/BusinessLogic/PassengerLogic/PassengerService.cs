using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using EntityDataAccessModels;
using PresentationModels.Driver;
using PresentationModels.Login;
using PresentationModels.Passenger;
using PassengerJourneyStatus = PresentationModels.Passenger.PassengerJourneyStatus;

namespace BusinessLogic.PassengerLogic
{
    /// <summary>
    /// Handles all the logic for passenger bookings 
    /// </summary>
    public class PassengerService
    {
        /// <summary>
        /// Deletes a passenger journey 
        /// </summary>
        /// <param name="passengerJourneyId"></param>
        public void DeleteJourney(int passengerJourneyId)
        {
            using (var context = new CarShareEntities())
            {
                var passengerJourney = context.PassengerJourneys.SingleOrDefault(c => c.PassengerJourneyId == passengerJourneyId);
                context.PassengerJourneys.Remove(passengerJourney);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Retrieves a single journey from the id
        /// </summary>
        /// <param name="passengerJourneyId"></param>
        /// <returns></returns>
        public ManagePassengerJourney GetJourney(int passengerJourneyId)
        {
            using (var context = new CarShareEntities())
            {
                var passengerJourney = context.PassengerJourneys.SingleOrDefault(c => c.PassengerJourneyId == passengerJourneyId);
                return new ManagePassengerJourney
                {
                    Status = new PassengerJourneyStatus
                    {
                        StatusId = passengerJourney.PassengerJourneyStatus.StatusId,
                        Name = passengerJourney.PassengerJourneyStatus.Name
                    }
                };
            }
        }

        /// <summary>
        /// Finds all of the driver journeys that match a user's search criteria 
        /// </summary>
        /// <param name="journey"></param>
        /// <param name="passengerId"></param>
        /// <returns></returns>
        public List<AvailableJourneys> FindJourneys(BookJourney journey, int passengerId)
        {
            using (var context = new CarShareEntities())
            {
                var availableJourneysList = context.DriverJourneys
                    .Where(u => u.Date == journey.Date)
                    .Where(u => u.JourneyStops.Any(j => j.LocationId == journey.Location.LocationId))
                    .Where(dj => !dj.JourneyStops.SelectMany(js => js.PassengerJourneys).Any(pj => pj.PassengerId == passengerId))
                    .Where(u => u.FromToWork == journey.FromToWork)
                    .Where(u => u.DriverId != passengerId)
                    .Where(u => u.IsLocked == false)
                    .Select(u => new AvailableJourneys
                    {
                        DriverJourney = new ManageJourneys
                        {
                            Driver = new PresUser
                            {
                                UserId = u.User.UserId,
                                Name = u.User.Name
                            },
                            TotalSeats = u.SeatsAvailable,
                            LeavingTime = u.LeavingTime,
                            DriverJourneyId = u.DriverJourneyId,
                            Date= journey.Date
                        },
                    }).ToList();
                return availableJourneysList;
            }
        }

        /// <summary>
        /// Lists all of the passenger journeys for a user 
        /// </summary>
        /// <returns></returns>
        public List<ManagePassengerJourney> ListJourneys()
        {
            using (var context = new CarShareEntities())
            {
                var passengerJourneyList = context.PassengerJourneys.Select(c =>
                new ManagePassengerJourney
                {
                    PassengerJourneyId = c.PassengerJourneyId,
                    Date = c.JourneyStop.DriverJourney.Date,
                    Driver = new PresUser
                    {
                        UserId = c.JourneyStop.DriverJourney.User.UserId,
                        Name = c.JourneyStop.DriverJourney.User.Name
                    },
                    Location = new PresLocation
                    {
                        LocationId = c.JourneyStop.Location.LocationId,
                        Name = c.JourneyStop.Location.Name,
                        DistanceToWork = c.JourneyStop.Location.DistanceToWork
                    },
                    Status = new PresentationModels.Passenger.PassengerJourneyStatus
                    {
                        StatusId = c.PassengerJourneyStatus.StatusId,
                        Name = c.PassengerJourneyStatus.Name
                    },
                    JourneyStop = new PresentationModels.Driver.JourneyStop
                    {
                        TimeFromHome = c.JourneyStop.TimeFromHome,
                        DriverJourney = new AddJourney
                        {
                            LeavingTime = c.JourneyStop.DriverJourney.LeavingTime
                        }
                    }
                }).ToList();
                return passengerJourneyList;
            }
        }

        /// <summary>
        /// Finds the journey stop based on the driverjourneyid and locationid
        /// </summary>
        /// <param name="journeyId"></param>
        /// <param name="locationId"></param>
        /// <returns></returns>
        public PresentationModels.Driver.JourneyStop GetStop(int journeyId, int locationId)
        {
            using (var context = new CarShareEntities())
            {
                var journeyStop = context.JourneyStops.Single(c =>
                c.DriverJourney.DriverJourneyId == journeyId && c.Location.LocationId == locationId);
                return new PresentationModels.Driver.JourneyStop
                {
                    JourneyStopId = journeyStop.JourneyStopId,
                    Location = new PresLocation
                    {
                        LocationId = journeyStop.Location.LocationId,
                        Name = journeyStop.Location.Name,
                        DistanceToWork = journeyStop.Location.DistanceToWork
                    },
                    DriverJourney = new AddJourney
                    {
                        DriverJourneyId = journeyStop.DriverJourneyId,
                        DriverId = journeyStop.DriverJourney.DriverId
                    },
                    TimeFromHome= journeyStop.TimeFromHome
                };
            }
        }

        /// <summary>
        /// lists all of the journeystops based on the driver journey id
        /// </summary>
        /// <param name="journeyID"></param>
        /// <returns></returns>
        public List<PresentationModels.Driver.JourneyStop> ListStops(int journeyID)
        {
            using (var context = new CarShareEntities())
            {
                var journeyStopList = context.JourneyStops.Select(c =>
                new PresentationModels.Driver.JourneyStop
                {
                    TimeFromHome = c.TimeFromHome,
                    Location = new PresLocation
                    {
                        LocationId = c.Location.LocationId,
                        Name = c.Location.Name,
                        DistanceToWork = c.Location.DistanceToWork
                    },
                    DriverJourney = new AddJourney
                    {
                        DriverJourneyId = c.DriverJourneyId
                    }
                }).Where(s => s.DriverJourney.DriverJourneyId == journeyID).ToList();
                return journeyStopList;
            }
        }

        /// <summary>
        /// Creates a journey for a passenger 
        /// </summary>
        /// <param name="passenger"></param>
        /// <param name="journeyStopId"></param>
        /// <param name="statusId"></param>
        public string CreateJourney(PresUser passenger, int driverJourneyId, int driverId, int journeyStopId, int statusId)
        {
            using (var context = new CarShareEntities())
            {
                var passengerJourney = new PassengerJourney()
                {
                    JourneyStopId = journeyStopId,
                    StatusId = statusId,
                    PassengerId = passenger.UserId
             
                };
                User newPassenger = context.Users.FirstOrDefault(u => u.UserId == passenger.UserId);
                var driverJourney = context.DriverJourneys.FirstOrDefault(dj => dj.DriverJourneyId == driverJourneyId);
                if (driverJourney.IsLocked == false)
                {
                    if (newPassenger.Driver.Any(d => d.UserId == driverId))
                    {
                        passengerJourney.StatusId = 1;
                    }
                    context.PassengerJourneys.Add(passengerJourney);
                    context.SaveChanges();
                    return "Journey has been successfully booked";   
                }
                else
                {
                    return "Failed to book journey. This journey has been locked by the driver";
                }
            }
        }

        /// <summary>
        /// Changes the approval status of a passenger's journey
        /// </summary>
        /// <param name="passengerJourneyId"></param>
        /// <param name="statusId"></param>
        public void UpdateJourney(int passengerJourneyId, int statusId)
        {
            using (var context = new CarShareEntities())
            {
                PassengerJourney journey = context.PassengerJourneys.FirstOrDefault(u => u.PassengerJourneyId == passengerJourneyId);
                journey.StatusId = statusId;
                context.PassengerJourneys.AddOrUpdate(journey);
                context.SaveChanges();
            }
        }
    }
}

