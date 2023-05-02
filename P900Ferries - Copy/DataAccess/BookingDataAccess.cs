using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessModels.Models.ScheduleModels;
using System.Configuration;
using DataAccessModels.Models.BookingModels;

namespace DataAccess
{
    public class BookingDataAccess
    {
        private string _ConnectionString = ConfigurationManager
           .ConnectionStrings["DefaultConnection"].ConnectionString;
        public int _BookingId;

        public void AddBookingToDatabase(BookingConfirmedData booking)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Booking_Insert", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("UserId", SqlDbType.NVarChar)).Value = booking.UserId;
                cmd.Parameters.Add(new SqlParameter("BookingReference", SqlDbType.NChar)).Value = booking.BookingReference;
                cmd.Parameters.Add(new SqlParameter("Cars", SqlDbType.Int)).Value = booking.Cars;
                cmd.Parameters.Add(new SqlParameter("Passengers", SqlDbType.Int)).Value = booking.Passengers;
                cmd.Parameters.Add(new SqlParameter("Cost", SqlDbType.Decimal)).Value = booking.Cost;
                cmd.Parameters.Add(new SqlParameter("CompanyName", SqlDbType.NVarChar)).Value = booking.CompanyName;
                cmd.Parameters.Add(new SqlParameter("FerryName", SqlDbType.NVarChar)).Value = booking.FerryName;
                cmd.Parameters.Add(new SqlParameter("DepartureDate", SqlDbType.DateTime2)).Value = booking.DepartureDate;
                cmd.Parameters.Add(new SqlParameter("DepartureLocation", SqlDbType.NVarChar)).Value = booking.DepartureLocation;
                cmd.Parameters.Add(new SqlParameter("ArrivalDate", SqlDbType.DateTime2)).Value = booking.ArrivalDate;
                cmd.Parameters.Add(new SqlParameter("ArrivalLocation", SqlDbType.NVarChar)).Value = booking.ArrivalLocation;
                cmd.Parameters.Add(new SqlParameter("BookingId", SqlDbType.Int)).Direction = ParameterDirection.Output;
                conn.Open();
                cmd.ExecuteNonQuery();
                _BookingId = (int)cmd.Parameters["BookingId"].Value;
            }
        }
        public void AddBookingContactToDatabase(ContactDetailsData bookingContact)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_BookingContact_Insert", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("BookingId", SqlDbType.Int)).Value = bookingContact.BookingId;
                cmd.Parameters.Add(new SqlParameter("Name", SqlDbType.NVarChar)).Value = bookingContact.Name;
                cmd.Parameters.Add(new SqlParameter("AddressLine1", SqlDbType.NChar)).Value = bookingContact.Line1;
                cmd.Parameters.Add(new SqlParameter("AddressLine2", SqlDbType.NVarChar)).Value = bookingContact.Line2;
                cmd.Parameters.Add(new SqlParameter("City", SqlDbType.NVarChar)).Value = bookingContact.City;
                cmd.Parameters.Add(new SqlParameter("PostalCode", SqlDbType.NVarChar)).Value = bookingContact.Postcode;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public List<LocationData> ListLocations()
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Location_List", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    var list = new List<LocationData>();
                    while (reader.Read())
                    {
                        list.Add(LocationFromRecord(reader));
                    }
                    return list;
                }
            }
        }
        private static LocationData LocationFromRecord(
                IDataRecord record)
        {
            return new LocationData()
            {
                LocationId = (int)record["LocationId"],
                Name = (string)record["Name"]
            };
        }
        public List<JourneyInfoData> ListJourneys(ChooseJourneyData chooseJourney)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Journeys_ListSearch", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("LocationFrom", SqlDbType.Int)).Value = chooseJourney.LocationFrom.LocationId;
                cmd.Parameters.Add(new SqlParameter("LocationTo", SqlDbType.Int)).Value = chooseJourney.LocationTo.LocationId;
                cmd.Parameters.Add(new SqlParameter("DateFrom", SqlDbType.TinyInt)).Value = (byte)chooseJourney.DayFrom;
                cmd.Parameters.Add(new SqlParameter("DepartingTime", SqlDbType.Time)).Value = chooseJourney.DepartingAfter;

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    var list = new List<JourneyInfoData>();
                    while (reader.Read())
                    {
                        list.Add(JourneyFromRecord(reader));
                    }
                    return list;
                }
            }
        }
        private static JourneyInfoData JourneyFromRecord(
         IDataRecord record)
        {
            return new JourneyInfoData()
            {
                FerryName = (string)record["FerryName"],
                CompanyName = (string)record["CompanyName"],
                JourneyId = (int)record["ScheduleId"],
                ArrivalDay = (byte)record["ArrivalDay"],
                ArrivalTime = (TimeSpan)record["ArrivalTime"],
                DepartureTime = (TimeSpan)record["DepartureTime"]
            };
        }
        public LocationData GetDataLocationById(int locationId)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Location_Get", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("LocationId", SqlDbType.Int)).Value = locationId;
                conn.Open();
                var location = new LocationData();
                using (var reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        location.LocationId = locationId;
                        location.Name = (string)reader["Name"];
                    }
                }
                return location;
            }
        }
        public JourneyInfoData GetJourneyById(ChooseJourneyData chooseJourney, int journeyId)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Journeys_Get", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("JourneyId", SqlDbType.Int)).Value = journeyId;
                cmd.Parameters.Add(new SqlParameter("LocationFrom", SqlDbType.Int)).Value = chooseJourney.LocationFrom.LocationId;
                cmd.Parameters.Add(new SqlParameter("LocationTo", SqlDbType.Int)).Value = chooseJourney.LocationTo.LocationId;
                cmd.Parameters.Add(new SqlParameter("DateFrom", SqlDbType.Int)).Value = chooseJourney.DayFrom;
                cmd.Parameters.Add(new SqlParameter("DepartingTime", SqlDbType.Time)).Value = chooseJourney.DepartingAfter;

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    var journeyInfo = new JourneyInfoData();
                    if (reader.Read())
                    {
                        journeyInfo = JourneyFromRecord(reader);
                    }
                    return journeyInfo;
                }
            }
        }
    }
}
