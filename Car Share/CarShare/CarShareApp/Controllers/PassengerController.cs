using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using BusinessLogic.DriverLogic;
using BusinessLogic.GeneralLogic;
using BusinessLogic.PassengerLogic;
using Microsoft.AspNet.Identity;
using PresentationModels.Driver;
using PresentationModels.Login;
using PresentationModels.Passenger;

namespace CarShareApp.Controllers
{
    /// <summary>
    /// Manages pages and actions for passenger bookings
    /// </summary>
    [Authorize]
    public class PassengerController : BaseController
    {
        private DriverStopService _DriverStop = new DriverStopService();
        private DriverJourneyService _DriverJourney = new DriverJourneyService();
        private PassengerService _Passenger = new PassengerService();
        private LocationService _Location = new LocationService();

        /// <summary>
        /// Initialises the components to open the passenger manage journey page
        /// </summary>
        /// <returns></returns>
        public ManagePassengerJourney InitialiseManageJourneys()
        {
            var manageJourney = new ManagePassengerJourney();
            manageJourney.JourneyGrid = _Passenger.ListJourneys();
            foreach (var model in manageJourney.JourneyGrid)
            {
                model.PickUpTime = ConvertFromIntToTime(model.JourneyStop.TimeFromHome) + model.JourneyStop.DriverJourney.LeavingTime;
            }
            return manageJourney;
        }

        /// <summary>
        /// Returns view with grid of all upcoming journeys booked by the user as
        /// a passenger
        /// </summary>
        /// <returns></returns>
        public ActionResult ManageJourneys()
        {
            
            return View(InitialiseManageJourneys());
        }

        /// <summary>
        /// If a user has been rejected or his/her request is still pending then deletes the passengerjourney 
        /// </summary>
        /// <param name="passengerJourneyId"></param>
        /// <returns></returns>
        public ActionResult CancelPassengerJourney(int passengerJourneyId)
        {
            var passengerJourney = _Passenger.GetJourney(passengerJourneyId);
            if (passengerJourney.Status.StatusId == 3 || passengerJourney.Status.StatusId == 2)
            {
                _Passenger.DeleteJourney(passengerJourneyId);
            }
            return View("ManageJourneys", InitialiseManageJourneys());
        }

        /// <summary>
        /// Allows user to search for available drivers depending on the inputted criteria
        /// </summary>
        /// <returns></returns>
        public ActionResult BookJourney(BookJourney journey)
        {
            if (journey.Location == null)
            {
                journey.AvailableJourneysGrid = null;
                journey.LocationList = _Location.List();
                return View(journey);
            }
            else
            {
                journey.AvailableJourneysGrid = _Passenger.FindJourneys(journey, ApplicationUser.UserId);
                journey.LocationList = _Location.List();
                return View(journey);
            }
        }

        /// <summary>
        /// Searches for all drivers matching search criteria and displays them in a grid
        /// </summary>
        /// <param name="journey"></param>
        /// <returns></returns>
        public ActionResult FindJourneys(BookJourney journey)
        {
            if (ModelState.IsValid)
            {
                journey.AvailableJourneysGrid = _Passenger.FindJourneys(journey, ApplicationUser.UserId);
                if (journey.AvailableJourneysGrid.Count == 0)
                {
                    ViewBag.Message = "No journeys matching your criteria found";
                }
                foreach (var item in journey.AvailableJourneysGrid)
                {
                    var stop = _Passenger.GetStop(item.DriverJourney.DriverJourneyId, journey.Location.LocationId);
                    item.JourneyStop = stop;
                    item.PickUpTime = ConvertFromIntToTime(stop.TimeFromHome) + item.DriverJourney.LeavingTime;
                    var stopList = _Passenger.ListStops(item.DriverJourney.DriverJourneyId);
                    for (int i = 0; i < stopList.Count; i++)
                    {
                        item.ArrivalTime = ConvertFromIntToTime(stopList[i].TimeFromHome + stopList[i].Location.DistanceToWork) + item.DriverJourney.LeavingTime;
                    }
                }
                journey.LocationList = _Location.List();
                return View("BookJourney", journey);
            }
            else
            {
                journey.LocationList = _Location.List();
                return View("BookJourney", journey);
            }
        }

        /// <summary>
        /// converts from an integer into a timespan type, so the arrival and pickup times
        /// can be calculated
        /// </summary>
        /// <param name="mins"></param>
        /// <returns></returns>
        public TimeSpan ConvertFromIntToTime(int mins)
        {
            var time = new TimeSpan(00, mins, 00);
            return time;
        }

        /// <summary>
        /// Creates a new passenger journey after a user books it
        /// </summary>
        /// <param name="journeyId"></param>
        /// <param name="locationId"></param>
        /// <returns></returns>
        public ActionResult CreatePassengerJourney(int journeyId, int locationId)
        {
            var journeyStop = _Passenger.GetStop(journeyId, locationId);
            var passenger = new PresUser
            {
                UserId = ApplicationUser.UserId,
                Name = ApplicationUser.Name
            };

            var message = _Passenger.CreateJourney(passenger, journeyStop.DriverJourney.DriverJourneyId,journeyStop.DriverJourney.DriverId, journeyStop.JourneyStopId, 3);
            if (message == "Journey has been successfully booked")
            {
                ViewBag.SuccessMessage = message;
            }
            else if (message == "Failed to book journey. This journey has been locked by the driver")
            {
                ViewBag.FailureMessage = message;
            }
            var journey = new BookJourney();
            journey.LocationList = _Location.List();
            return View("BookJourney", journey);
        }
    }
}
