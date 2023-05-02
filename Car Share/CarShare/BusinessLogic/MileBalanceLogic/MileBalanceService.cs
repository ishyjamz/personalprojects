using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityDataAccessModels;
using PresentationModels.Driver;
using PresentationModels.MileBalance;
using PresentationModels.Passenger;
using JourneyStop = PresentationModels.Driver.JourneyStop;
using PresentationModels.Login;

namespace BusinessLogic.MileBalanceLogic
{
    /// <summary>
    /// Contains all business logic to handle the mileage balance of each user
    /// </summary>
    public class MileBalanceService
    {
        /// <summary>
        /// Lists all of journey stops linking a driver to a passenger
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="passengerId"></param>
        /// <returns></returns>
        public List<JourneyStop> ListJourneyStops(int userId, int passengerId)
        {
            using (var context = new CarShareEntities())
            {
                var journeyStopList = context.JourneyStops
                    .Where(c => c.DriverJourney.DriverId == userId)
                    .Where(c => c.PassengerJourneys.Any(u => u.PassengerId == passengerId))
                    .Where(c => c.DriverJourney.Date < DateTime.Today)
                    .Select(c => new JourneyStop
                    {
                        Location = new PresLocation
                        {
                            DistanceToWork = c.Location.DistanceToWork
                        }
                    }).ToList();
                return journeyStopList;
            }
        }

        /// <summary>
        /// Returns a list of users. The miles owed and miles gained calculations 
        /// are done in the controller
        /// </summary>
        /// <returns></returns>
        public List<MileBalance> ListMileBalance()
        {
            using (var context = new CarShareEntities())
            {
                var mileBalanceList = context.Users.Select(u => 
                new MileBalance
                {
                    User = new PresUser
                    {
                        UserId = u.UserId,
                        Name = u.Name
                    }
                }).ToList();
                return mileBalanceList;
            }
        }
    }
}
