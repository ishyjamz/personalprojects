using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using Microsoft.AspNet.Identity;
//using Microsoft.AspNetCore.Mvc;
using Microsoft.Owin.BuilderProperties;
using Models.Models.BookingModels;

namespace FerryWebApp.Controllers
{
    [Authorize(Roles = "Customer")]
    public class BookingController : Controller
    {
        public BookingService _Booking = new BookingService();
        // GET: Booking
        public ActionResult JourneyPicker()
        {
            var journey = new ChooseJourneyModel(); 
            journey.LocationList = _Booking.GetLocationList();  
            return View("JourneyPicker", journey);
        }
        public ActionResult StoreJourney(ChooseJourneyModel journey)
        {
            journey.LocationFrom = _Booking.GetLocationById(journey.LocationFrom.LocationId);
            journey.LocationTo = _Booking.GetLocationById(journey.LocationTo.LocationId);
            Session["journey"] = journey;
            return RedirectToAction("ListJourneys", journey);
        }
        public ActionResult ListJourneys(ChooseJourneyModel journey)
        {
            journey = (ChooseJourneyModel)Session["journey"];
            journey.JourneyGrid = _Booking.ListJourneysMain(journey);
            return View("ListJourneys", journey);
        }
        public ActionResult StoreJourneyInfo(int journeyId)
        {
            var journey = (ChooseJourneyModel)Session["journey"];
            var journeyInfo = _Booking.GetJourneyById(journey, journeyId);
            Session["journeyInfo"] = journeyInfo;
            return RedirectToAction("SelectCarsPassengers", new { id = journeyInfo.JourneyId });
        }

        //[Route("Booking/SelectCarsPassengers/{id:int}")]
        [HttpGet]
        public ActionResult SelectCarsPassengers(int id)
        {
            var schedule = _Booking.GetScheduleById(id);
            var carsPassengers = new CarsPassengers();
            carsPassengers.CostPerVehicle = schedule.CostPerVehicle;
            carsPassengers.CostPerPerson = schedule.CostPerPerson;

            return View("SelectCarsPassengers", carsPassengers);
        }
        [HttpPost]
        public ActionResult StoreCarsPassengers(CarsPassengers carsPassengers)
        {
            if (ModelState.IsValid)
            {
                carsPassengers.TotalCost = (carsPassengers.CostPerVehicle * carsPassengers.NumberOfCars)
                + (carsPassengers.CostPerPerson * carsPassengers.NumberOfPassengers);
                Session["carsPassengers"] = carsPassengers;
                return RedirectToAction("BookingAddress");
            }
            return null;
        }
        public ActionResult BookingAddress()
        {
            return View();
        }
        [HttpPost]
        public ActionResult StoreContactDetails(ContactDetails address)
        {
            if (ModelState.IsValid)
            {
                Session["address"] = address;
                return RedirectToAction("BookingSummary");
            }
            else
            {
                return View("BookingAddress", address);
            }
        }
        public ActionResult BookingSummary()
        {
            var addressData = (ContactDetails)Session["address"];
            var journeyData = (ChooseJourneyModel)Session["journey"];
            var journeyInfoData = (JourneyInfo)Session["journeyInfo"];
            var carsPassengersData = (CarsPassengers)Session["carsPassengers"];
            var bookingSummary = new BookingSummary
            {
                PersonName = addressData.Name,
                Line1 = addressData.Line1,
                Line2 = addressData.Line2,
                City = addressData.City,
                Postcode = addressData.Postcode,
                DepartureLocation = journeyData.LocationFrom.Name,
                DepartTime = journeyInfoData.DepartureTime,
                ArrivalLocation = journeyData.LocationTo.Name,
                ArrivalTime = journeyInfoData.ArrivalTime,
                ArrivalDate = journeyInfoData.ArrivalDate,
                DateFrom = journeyData.DateFrom,
                NumberOfCars = carsPassengersData.NumberOfCars,
                NumberOfPassengers = carsPassengersData.NumberOfPassengers,
                TotalCost = carsPassengersData.TotalCost
            };
            Session["bookingSummary"] = bookingSummary;
            return View(bookingSummary);
        }
        public ActionResult BookingConfirmed()
        {
            var addressData = (ContactDetails)Session["address"];
            var journeyData = (ChooseJourneyModel)Session["journey"];
            var journeyInfoData = (JourneyInfo)Session["journeyInfo"];
            var carsPassengersData = (CarsPassengers)Session["carsPassengers"];
            var bookingSummary = (BookingSummary)Session["bookingSummary"];
            
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[5];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var bookingRef = new String(stringChars);

            var booking = new BookingConfirmed()
            {
                UserId = User.Identity.GetUserId(),
                BookingReference = bookingRef,
                ArrivalDate = journeyInfoData.ArrivalDate,
                ArrivalLocation = journeyData.LocationTo.Name,
                Cars = carsPassengersData.NumberOfCars,
                Passengers = carsPassengersData.NumberOfPassengers,
                Cost = carsPassengersData.TotalCost,
                CompanyName= journeyInfoData.CompanyName,
                FerryName = journeyInfoData.FerryName,
                DepartureDate = journeyData.DateFrom,
                DepartureLocation = journeyData.LocationFrom.Name,
            };
            return View(booking);
        }
        public ActionResult SaveBooking(BookingConfirmed booking)
        {
            _Booking.AddBooking(booking);
            return RedirectToAction("AddBookingContact", booking);
        }
        public ActionResult AddBookingContact(BookingConfirmed booking)
        {
            var bookingContact = (ContactDetails)Session["address"];
            bookingContact.BookingId = booking.BookingId;
            _Booking.AddBookingContact(bookingContact);
            return RedirectToAction("JourneyPicker");
        }
    }
}
