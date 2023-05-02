using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using BusinessLogic.DriverLogic;
using BusinessLogic;
using Microsoft.AspNet.Identity;
using PresentationModels.Driver;
using PresentationModels.Login;
using BusinessLogic.GeneralLogic;
using System.Management.Instrumentation;
using PresentationModels.Passenger;
using System.Data.Entity.Core.Common.CommandTrees;

namespace CarShareApp.Controllers
{
    /// <summary>
    /// Manages all the pages for driver journeys, stops and approved passengers
    /// </summary>
    [Authorize]
    public class DriverController : BaseController
    {
        private DriverStopService _DriverStop = new DriverStopService();
        private LocationService _Location = new LocationService();
        private DriverJourneyService _DriverJourney = new DriverJourneyService();

        /// <summary>
        /// initialises all the required object for the manage journeys page
        /// </summary>
        /// <returns></returns>
        public ManageJourneys InitialiseManageJourneys()
        {
            var manageJourney = new ManageJourneys();
            manageJourney.JourneyGrid = _DriverJourney.List(ApplicationUser.UserId);
            foreach (var item in manageJourney.JourneyGrid)
            {
                var passengers = _DriverJourney.ListApprovedPassengersForJourney(item.DriverJourneyId);
                item.Passengers = new List<PresUser>();
                foreach (var passenger in passengers)
                {
                    item.Passengers.Add(passenger);
                }
                if (item.SeatsAvailable == 0)
                {
                    _DriverJourney.LockJourney(item.DriverJourneyId);
                }
            }
            return manageJourney;
        }

        /// <summary>
        /// returns a view with a grid of all the journeys
        /// </summary>
        /// <returns></returns>
        public ActionResult ManageJourneys()
        {
            
            return View(InitialiseManageJourneys());
        }

        /// <summary>
        /// Locks a driver's journey so no one can book onto it
        /// </summary>
        /// <param name="driverJourneyId"></param>
        /// <returns></returns>
        public ActionResult LockJourney(int driverJourneyId)
        {
            _DriverJourney.LockJourney(driverJourneyId);

            return View("ManageJourneys", InitialiseManageJourneys());
        }

        /// <summary>
        /// Unlocks a journey so users can book onto it 
        /// </summary>
        /// <param name="driverJourneyId"></param>
        /// <returns></returns>
        public ActionResult UnlockJourney(int driverJourneyId)
        {
            _DriverJourney.UnlockJourney(driverJourneyId);
            return View("ManageJourneys", InitialiseManageJourneys());
        }

        /// <summary>
        /// Returns view where a new journey can be made for a driver 
        /// </summary>
        /// <returns></returns>
        public ActionResult AddJourney()
        {
            var journey = new AddJourney();
            journey.StopsGrid = _DriverJourney.ListStops(ApplicationUser.UserId);
            return View(journey);
        }

        /// <summary>
        /// creates a new journey for driver 
        /// </summary>
        /// <param name="journey"></param>
        /// <returns></returns>
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult CreateJourney(AddJourney journey)
        {
            journey.DriverId = ApplicationUser.UserId;
            journey.StopsGrid = _DriverJourney.ListStops(ApplicationUser.UserId);
            if (!ModelState.IsValid)
            {
                return View("AddJourney", journey);
            }
            else
            {
                journey.StopsGrid = _DriverJourney.ListStops(ApplicationUser.UserId);
                _DriverJourney.Create(journey);
                ViewBag.SuccessMessage = "Journey successfully created";
                ModelState.Clear();
                var addJourney = new AddJourney();
                addJourney.StopsGrid = _DriverJourney.ListStops(ApplicationUser.UserId);
                return View("AddJourney", addJourney);
            }
        }

        /// <summary>
        /// Returns view with a grid of all the approved passengers for a driver
        /// </summary>
        /// <returns></returns>
        public ActionResult ApprovedPassengers(ApprovedPassengers approvedPassenger)
        {
            approvedPassenger.ApprovedList = _DriverJourney.ListApprovedPassengers(ApplicationUser.UserId);
            approvedPassenger.Passengers = _User.List(ApplicationUser.UserId);
            return View(approvedPassenger);
        }

        /// <summary>
        /// Adds an approved passenger to a user's approved passengers list
        /// </summary>
        /// <param name="approved"></param>
        /// <returns></returns>
        public ActionResult AddApprovedPassenger(ApprovedPassengers approved)
        {
            if (ModelState.IsValid)
            {
                _DriverJourney.ApprovePassenger(ApplicationUser.UserId, approved.PassengerId);
                approved.Passengers = _User.List(ApplicationUser.UserId);
                approved.ApprovedList = _DriverJourney.ListApprovedPassengers(ApplicationUser.UserId);
                return View("ApprovedPassengers", approved);
            }
            else
            {
                approved.Passengers = _User.List(ApplicationUser.UserId);
                approved.ApprovedList = _DriverJourney.ListApprovedPassengers(ApplicationUser.UserId);
                return View("ApprovedPassengers", approved);
            }
        }

        /// <summary>
        /// Removes a passenger from a user's approved list
        /// </summary>
        /// <param name="passengerId"></param>
        /// <returns></returns>
        public ActionResult RemovePassenger(int passengerId)
        {
            _DriverJourney.RemovePassenger(ApplicationUser.UserId, passengerId);
            var approved = new ApprovedPassengers();
            approved.Passengers = _User.List(ApplicationUser.UserId);
            approved.ApprovedList = _DriverJourney.ListApprovedPassengers(ApplicationUser.UserId);
            return View("ApprovedPassengers", approved);
        }

        /// <summary>
        /// Returns a view with all the stops that a driver is willing to make on the
        /// way to work
        /// </summary>
        /// <returns></returns>
        public ActionResult Stops()
        {
            var stop = new Stops();
            stop.StopsGrid = _DriverStop.List(ApplicationUser.UserId);
            stop.LocationList = _Location.List();
            return View(stop);
        }

        /// <summary>
        /// Deletes a stop from the driver's stops list
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult DeleteStop(int id)
        {
            _DriverStop.Delete(ApplicationUser.UserId, id);
            return RedirectToAction("Stops");
        }

        /// <summary>
        /// Opens a partial view with a modal allowing user to add a new stop
        /// </summary>
        /// <param name="stop"></param>
        /// <returns></returns>
        public ActionResult AddStop(Stops stop)
        {
            return PartialView("AddStop", stop);
        }

        /// <summary>
        /// Inserts the new stop in database
        /// </summary>
        /// <param name="stop"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CreateStop(Stops stop)
        {
            
            if (ModelState.IsValid)
            {
                stop.DriverId = ApplicationUser.UserId;
                var message = _DriverStop.Create(stop);
                ViewBag.Message = message;
                var newStop = new Stops();
                newStop.StopsGrid = _DriverStop.List(ApplicationUser.UserId);
                newStop.LocationList = _Location.List();
                return View("Stops", newStop);
            }
            else
            {
                var newStop = new Stops();
                newStop.StopsGrid = _DriverStop.List(ApplicationUser.UserId);
                newStop.LocationList = _Location.List();
                return View("Stops", newStop);
            }
        }
    }
}
