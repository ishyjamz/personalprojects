using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic.DriverLogic;
using BusinessLogic.GeneralLogic;
using BusinessLogic.PassengerLogic;
using Microsoft.AspNet.Identity;
using PresentationModels.Driver;
using PresentationModels.Home;
using PresentationModels.Login;
using PresentationModels.Passenger;

namespace CarShareApp.Controllers
{
    /// <summary>
    /// Home controller handling the passenger notifcations and driver requests
    /// </summary>
    [Authorize]
    public class HomeController : BaseController
    {
        private DriverRequestService _Request = new DriverRequestService();
        private DriverJourneyService _DriverJourney = new DriverJourneyService();
        private PassengerService _Passenger = new PassengerService();
        private PassengerNotificationService _Notification = new PassengerNotificationService();

        /// <summary>
        /// Returns view of the home page which the user is sent to when logged in
        /// </summary>
        /// <returns></returns>
        public ActionResult Home()
        {
            var home = new Home
            {
                DriverRequest = new DriverRequest
                {
                    DriverRequests = _Request.ListRequests(ApplicationUser.UserId)
                },
                Notification = new PassengerNotification
                {
                    NotificationGrid = _Notification.List(ApplicationUser.UserId)
                }
            };
            return View(home);
        }

        /// <summary>
        /// Approves a passenger request and adds them to the approved list of passengers and changes the passengers
        /// journey status to approved
        /// </summary>
        /// <param name="passengerJourneyId"></param>
        /// <param name="passengerId"></param>
        /// <returns></returns>
        public ActionResult ApproveRequest(int passengerJourneyId, int passengerId)
        {
            _DriverJourney.ApprovePassenger(ApplicationUser.UserId, passengerId);
            _Passenger.UpdateJourney(passengerJourneyId, 1);
            _Notification.Create(passengerJourneyId);
            var home = new Home
            {
                DriverRequest = new DriverRequest
                {
                    DriverRequests = _Request.ListRequests(ApplicationUser.UserId)
                },
                Notification = new PassengerNotification
                {
                    NotificationGrid = _Notification.List(ApplicationUser.UserId)
                }
            };

            return View("Home", home);
        }

        /// <summary>
        /// Rejects a passenger's request
        /// </summary>
        /// <param name="passengerJourneyId"></param>
        /// <returns></returns>
        public ActionResult RejectRequest(int passengerJourneyId)
        {
            _Passenger.UpdateJourney(passengerJourneyId, 2);
            _Notification.Create(passengerJourneyId);
            var home = new Home
            {
                DriverRequest = new DriverRequest
                {
                    DriverRequests = _Request.ListRequests(ApplicationUser.UserId)
                },
                Notification = new PassengerNotification
                {
                    NotificationGrid = _Notification.List(ApplicationUser.UserId)
                }
            };
            return View("Home", home);
        }

        /// <summary>
        /// Removes notification from the grid
        /// </summary>
        /// <param name="notificationId"></param>
        /// <returns></returns>
        public ActionResult DismissNotification(int notificationId)
        {
            _Notification.Delete(notificationId);
            var home = new Home
            {
                DriverRequest = new DriverRequest
                {
                    DriverRequests = _Request.ListRequests(ApplicationUser.UserId)
                },
                Notification = new PassengerNotification
                {
                    NotificationGrid = _Notification.List(ApplicationUser.UserId)
                }
            };
            return View("Home", home);
        }
    }
}
