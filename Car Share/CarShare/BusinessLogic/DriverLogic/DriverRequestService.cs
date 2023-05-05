using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityDataAccessModels;
using PresentationModels.Driver;
using PresentationModels.Login;
using PresentationModels.Passenger;

namespace BusinessLogic.DriverLogic
{
    /// <summary>
    /// Contains business logic to handle requests for drivers
    /// </summary>
    public class DriverRequestService
    {
        /// <summary>
        /// Lists all of the requests made by passengers onto a driver's journey
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<DriverRequest> ListRequests(int userId)
        {
            using (var context = new CarShareEntities())
            {
                var driverRequestsList = context.PassengerJourneys
                    .Where(c => c.JourneyStop.DriverJourney.User.UserId == userId)
                    .Where(c => c.PassengerJourneyStatus.StatusId == 3)
                    .Select(c => new DriverRequest
                    {
                        Date = c.JourneyStop.DriverJourney.Date,
                        Passenger = new PresUser
                        {
                            UserId = c.User.UserId,
                            Name = c.User.Name
                        },
                        Stop = new PresentationModels.Driver.JourneyStop
                        {
                            Location = new PresLocation
                            {
                                LocationId = c.JourneyStop.Location.LocationId,
                                Name = c.JourneyStop.Location.Name
                            }
                        },
                        Journey = new BookJourney
                        {
                            PassengerJourneyId = c.PassengerJourneyId
                        }
                    }).ToList();
                return driverRequestsList;
            }
        }
    }
}
