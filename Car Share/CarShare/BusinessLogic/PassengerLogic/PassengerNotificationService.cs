using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityDataAccessModels;
using PresentationModels.Passenger;
using PresentationModels.Driver;
using PresentationModels.Login;

namespace BusinessLogic.PassengerLogic
{
    /// <summary>
    /// Business logic to handle passenger notifications which appear when a driver
    /// has either approved or rejected a request from a passenger
    /// </summary>
    public class PassengerNotificationService
    {
        /// <summary>
        /// Lists all of the notifications belonging to a user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<PassengerNotification> List(int userId)
        {
            using (var context = new CarShareEntities())
            {
                var notificiationList = context.Notifications.Where(c => c.PassengerJourney.PassengerId == userId)
                    .Select(c => new PassengerNotification
                    {
                        NotificationId = c.NotificationId,
                        PassengerJourney = new ManagePassengerJourney
                        {
                            Date = c.PassengerJourney.JourneyStop.DriverJourney.Date,
                            Driver = new PresUser
                            {
                                UserId = c.PassengerJourney.JourneyStop.DriverJourney.User.UserId,
                                Name = c.PassengerJourney.JourneyStop.DriverJourney.User.Name
                            },
                            Status = new PresentationModels.Passenger.PassengerJourneyStatus
                            {
                                StatusId = c.PassengerJourney.StatusId,
                                Name = c.PassengerJourney.PassengerJourneyStatus.Name
                            },
                        }
                    }).ToList();
                return notificiationList;
            }
        }

        /// <summary>
        /// Creates a new notification for when a driver approves/rejects passengers request
        /// </summary>
        /// <param name="passengerJourneyId"></param>
        public void Create(int passengerJourneyId)
        {
            using (var context = new CarShareEntities())
            {
                var notification = new Notification
                {
                    PassengerJourneyId = passengerJourneyId
                };
                context.Notifications.Add(notification);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Deletes a notification once a user clicks the dismiss button
        /// </summary>
        /// <param name="notificationId"></param>
        public void Delete(int notificationId)
        {
            using (var context = new CarShareEntities())
            {
                var notification = context.Notifications.FirstOrDefault(c => c.NotificationId == notificationId);
                context.Notifications.Remove(notification);
                context.SaveChanges();
            }
        }
    }
}
