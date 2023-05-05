using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccessModels.Models.BookingModels;
using DataAccessModels.Models.FerryModels;
using DataAccessModels.Models.ScheduleModels;
using Models.Models.BookingModels;
using Models.Models.FerryModels;
using Models.Models.ScheduleModels;

namespace BusinessLayer
{
    public class BookingService
    {
        public BookingDataAccess _BookingData = new BookingDataAccess();
        public ScheduleDataAccess _ScheduleData = new ScheduleDataAccess();    
        private DateTime _RefDate;
        public int _BookingId;
        public void AddBookingContact(ContactDetails bookingContact)
        {
            bookingContact.BookingId = _BookingId;
            _BookingData.AddBookingContactToDatabase(ConvertToDataContactDetails(bookingContact));

        }
        public void AddBooking(BookingConfirmed booking)
        {
            _BookingData.AddBookingToDatabase(ConvertToDataBookingConfirmed(booking));
            _BookingId = _BookingData._BookingId;
        }
        public ContactDetailsData ConvertToDataContactDetails(ContactDetails bookingContact)
        {
            return new ContactDetailsData
            {
                Name = bookingContact.Name,
                Line1 = bookingContact.Line1,
                Line2 = bookingContact.Line2,
                City = bookingContact.City,
                Postcode = bookingContact.Postcode
            };
        }
        public BookingConfirmedData ConvertToDataBookingConfirmed(BookingConfirmed booking)
        {
            return new BookingConfirmedData
            {
                UserId = booking.UserId,
                BookingReference = booking.BookingReference,
                Cars = booking.Cars,
                Passengers = booking.Passengers,
                Cost = booking.Cost,
                CompanyName = booking.CompanyName,
                FerryName = booking.FerryName,
                DepartureDate = booking.DepartureDate,
                DepartureLocation = booking.DepartureLocation,
                ArrivalDate = booking.ArrivalDate,
                ArrivalLocation = booking.ArrivalLocation,
            };
        }
        public ScheduleViewModel GetScheduleById(int scheduleId)
        {
            var dataSchedule = _ScheduleData.GetDataScheduleById(scheduleId);
            var presentationSchedule = ConvertToPresViewSchedule(dataSchedule);
            return presentationSchedule;
        }
        public ScheduleViewModel ConvertToPresViewSchedule(ScheduleDataModel scheduleData)
        {
            var schedule = new ScheduleViewModel
            {
                ScheduleId = scheduleData.ScheduleId,
                FerryId = scheduleData.FerryId,
                Description = scheduleData.Description,
                CostPerPerson = scheduleData.CostPerPerson,
                CostPerVehicle = scheduleData.CostPerVehicle,
                RowVersion = scheduleData.RowVersion,
            };
            return schedule;
        }
        public List<Location> GetLocationList()
        {
            var list = _BookingData.ListLocations();
            var preslist = new List<Location>();
            foreach (var model in list)
            {
                preslist.Add(ConvertToPresentationLocation(model));
            }
            return preslist;
        }
        private static Location ConvertToPresentationLocation(LocationData locationData)
        {
            return new Location()
            {
                LocationId = locationData.LocationId,
                Name = locationData.Name
            };
        }
        public List<JourneyInfo> ListJourneysMain(ChooseJourneyModel journey)
        {
            _RefDate = journey.DateFrom;
            var journeyDataList = ListJourneys(journey);
            var presentationList = new List<JourneyInfo>();
            foreach (var subModel in journeyDataList)
            {
                presentationList.Add(ConvertToPresentationJourney(subModel));
            }
            return presentationList;
        }
        public List<JourneyInfoData> ListJourneys(ChooseJourneyModel journey)
        {

            var list = _BookingData.ListJourneys(ConvertToDataJourney(journey));
            return list;
        
        }

        public JourneyInfo ConvertToPresentationJourney(JourneyInfoData journeyData)
        {

            var journeyInfo = new JourneyInfo()
            {
                FerryName = journeyData.FerryName,
                CompanyName = journeyData.CompanyName,
                JourneyId = journeyData.JourneyId,
                ArrivalDate = ConvertDayToDate((DayOfWeek)journeyData.ArrivalDay, _RefDate),
                ArrivalTime = journeyData.ArrivalTime,
                DepartureTime = journeyData.DepartureTime,
            };
            return journeyInfo;
        }

        private static DateTime ConvertDayToDate(DayOfWeek day, DateTime refDate)
        {
            int refDayValue = (int)refDate.DayOfWeek;
            int dayValue = (int)day - 1;
            int diffDays = dayValue - refDayValue;
            if (diffDays >= 0)
            {
                return refDate.AddDays(diffDays);
            }
            else
            {
                return refDate.AddDays(7 + diffDays);
            }
        }

        private static int ConvertFromDateToDay(DateTime dateFrom)
        {
            int day = (int)dateFrom.DayOfWeek - 1;
            return day;
        }
        private static ChooseJourneyData ConvertToDataJourney(ChooseJourneyModel journey)
        {
            return new ChooseJourneyData()
            {
                LocationFrom = ConvertToLocationData(journey.LocationFrom),
                LocationTo = ConvertToLocationData(journey.LocationTo),
                DayFrom = ConvertFromDateToDay(journey.DateFrom),    
                DepartingAfter = journey.DepartingAfter
            
            };
        }
        private static LocationData ConvertToLocationData (Location location)
        {
            return new LocationData
            {
                LocationId = location.LocationId,
                Name = location.Name
            };
        }
        public Location GetLocationById(int locationId)
        {
            var dataLocation = _BookingData.GetDataLocationById(locationId);
            var presentationLocation = ConvertToPresViewLocation(dataLocation);
            return presentationLocation;
        }
        public Location ConvertToPresViewLocation(LocationData locationData)
        {
            var location = new Location
            {
                LocationId = locationData.LocationId,
                Name = locationData.Name
            };
            return location;
        }
        public JourneyInfo GetJourneyById(ChooseJourneyModel journey, int journeyId)
        {
            _RefDate = journey.DateFrom;
            var dataJourney = _BookingData.GetJourneyById(ConvertToDataJourney(journey), journeyId);
            var presentationJourney = ConvertToPresentationJourney(dataJourney);
            return presentationJourney;
        }
    }
}
