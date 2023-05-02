using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessModels.Models.ScheduleModels;
using System.Configuration;
using DataAccessModels.Models.FerryModels;
using DataAccessModels.Models.CompanyModels;

namespace DataAccess
{
    public class ScheduleDataAccess
    {
        private string _ConnectionString = ConfigurationManager
           .ConnectionStrings["DefaultConnection"].ConnectionString;
        public void AddScheduleToDatabase(string description, decimal costPerPerson, decimal costPerVehicle, int ferryId)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Schedule_Insert", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("Description", SqlDbType.NVarChar)).Value = description;
                cmd.Parameters.Add(new SqlParameter("CostPerPerson", SqlDbType.Decimal)).Value = costPerPerson;
                cmd.Parameters.Add(new SqlParameter("CostPerVehicle", SqlDbType.Decimal)).Value = costPerVehicle;
                cmd.Parameters.Add(new SqlParameter("FerryId", SqlDbType.Decimal)).Value = ferryId;

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void AddScheduleStop(ScheduleStopData stopData)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_ScheduleStop_Insert", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("ScheduleId", SqlDbType.Int)).Value = stopData.ScheduleId;
                cmd.Parameters.Add(new SqlParameter("DepartureDay", SqlDbType.TinyInt)).Value = stopData.DepartureDay;
                cmd.Parameters.Add(new SqlParameter("ArrivalDay", SqlDbType.TinyInt)).Value = stopData.ArrivalDay;
                cmd.Parameters.Add(new SqlParameter("DepartureTime", SqlDbType.Time)).Value = stopData.DepartureTime;
                cmd.Parameters.Add(new SqlParameter("ArrivalTime", SqlDbType.Time)).Value = stopData.ArrivalTime;
                cmd.Parameters.Add(new SqlParameter("LocationId", SqlDbType.Int)).Value = stopData.Location.LocationId;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public List<ScheduleDataModel> ListSchedules(int ferryId)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Ferry_ListSchedules", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("FerryId", SqlDbType.Int)).Value = ferryId;
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    var list = new List<ScheduleDataModel>();
                    while (reader.Read())
                    {
                        list.Add(ScheduleFromRecord(reader));
                    }
                    return list;
                }
            }
        }
        public List<ScheduleStopData> ListScheduleStops(int scheduleId)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_ScheduleStop_Get", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("ScheduleId", SqlDbType.Int)).Value = scheduleId;
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    var list = new List<ScheduleStopData>();
                    while (reader.Read())
                    {
                        list.Add(ScheduleStopFromRecord(reader));
                    }
                    return list;
                }
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
        private static ScheduleDataModel ScheduleFromRecord(
          IDataRecord record)
        {
            return new ScheduleDataModel()
            {
                ScheduleId = (int)record["ScheduleId"],
                Description = record["Description"].Equals(DBNull.Value) ? "" : (string)record["Description"],
                CostPerPerson = (decimal)record["CostPerPerson"],
                CostPerVehicle = (decimal)record["CostPerVehicle"],
            };
        }
        private static ScheduleStopData ScheduleStopFromRecord(
          IDataRecord record)
        {
            return new ScheduleStopData()
            {
                ScheduleStopId = record["ScheduleStopId"].Equals(DBNull.Value) ? 0 : (int)record["ScheduleStopId"],
                ScheduleId = record["ScheduleId"].Equals(DBNull.Value) ? 0 : (int)record["ScheduleId"],
                DepartureDay = record["DepartureDay"].Equals(DBNull.Value) ? 0 : (int)(byte)record["DepartureDay"],
                DepartureTime = record["DepartureTime"].Equals(DBNull.Value) ? new TimeSpan(00-00-00) : (TimeSpan)record["DepartureTime"],
                ArrivalDay = record["ArrivalDay"].Equals(DBNull.Value) ? 0 : (int)(byte)record["ArrivalDay"],
                ArrivalTime = record["ArrivalTime"].Equals(DBNull.Value) ? new TimeSpan(00 - 00 - 00) : (TimeSpan)record["ArrivalTime"],
                Location = new LocationData()
                {
                    LocationId = record["LocationId"].Equals(DBNull.Value) ? 0 : (int)record["LocationId"]
                }
            };
        }
        public ScheduleDataModel GetDataScheduleById(int id)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Schedule_Get", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("ScheduleId", SqlDbType.Int)).Value = id;
                conn.Open();
                var schedule = new ScheduleDataModel();
                using (var reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        schedule.ScheduleId = id;
                        schedule.FerryId = (int)reader["FerryId"];
                        schedule.Description = reader["Description"].Equals(DBNull.Value) ? "" : (string)reader["Description"];
                        schedule.CostPerPerson = (decimal)reader["CostPerPerson"];
                        schedule.CostPerVehicle = (decimal)reader["CostPerVehicle"];
                        schedule.RowVersion = (byte[])reader["RowVersion"]; 
                    }
                }
                return schedule;
            }
        }
        public ScheduleDataModel GetDataScheduleStopById(int id)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Schedule_Get", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("ScheduleId", SqlDbType.Int)).Value = id;
                conn.Open();
                var schedule = new ScheduleDataModel();
                using (var reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        schedule.Stops.ScheduleStopId = reader["ScheduleStopId"].Equals(DBNull.Value) ? 0 : (int)reader["ScheduleStopId"];
                        schedule.Stops.ScheduleId = reader["ss.ScheduleId"].Equals(DBNull.Value) ? 0 : (int)reader["ss.ScheduleId"];
                        schedule.Stops.DepartureDay = reader["DepartureDay"].Equals(DBNull.Value) ? 0 : (int)reader["DepartureDay"];
                        schedule.Stops.ArrivalDay = reader["ArrivalDay"].Equals(DBNull.Value) ? 0 : (int)reader["ArrivalDay"];
                        schedule.Stops.DepartureTime = reader["DepartureTime"].Equals(DBNull.Value) ? new TimeSpan(00-00-00) : (TimeSpan)reader["DepartureTime"];
                        schedule.Stops.ArrivalTime = reader["ArrivalTime"].Equals(DBNull.Value) ? new TimeSpan(00 - 00 - 00) : (TimeSpan)reader["ArrivalTime"];
                        schedule.Stops.Location.Name = reader["l.Name"].Equals(DBNull.Value) ? "" : (string)reader["l.Name"];
                        schedule.Stops.Location.LocationId = reader["l.LocationId"].Equals(DBNull.Value) ? 0 : (int)reader["l.LocationId"];
                    }
                }
                return schedule;
            }
        }
        public ScheduleDataModel UpdateDataSchedule(ScheduleDataModel schedule)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Schedule_Update", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("ScheduleId", SqlDbType.Int)).Value = schedule.ScheduleId;
                cmd.Parameters.Add(new SqlParameter("FerryId", SqlDbType.Int)).Value = schedule.FerryId;
                cmd.Parameters.Add(new SqlParameter("Description", SqlDbType.NVarChar)).Value = schedule.Description;
                cmd.Parameters.Add(new SqlParameter("CostPerPerson", SqlDbType.Decimal)).Value = schedule.CostPerPerson;
                cmd.Parameters.Add(new SqlParameter("CostPerVehicle", SqlDbType.Decimal)).Value = schedule.CostPerVehicle;
                cmd.Parameters.Add(new SqlParameter("RowVersion", SqlDbType.Timestamp)).Value = schedule.RowVersion;

                conn.Open();
                var scheduleModel = new ScheduleDataModel();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        scheduleModel.ScheduleId = (int)reader["ScheduleId"];
                        scheduleModel.FerryId = (int)reader["FerryId"];
                        schedule.Description = reader["Description"].Equals(DBNull.Value) ? "" : (string)reader["Description"];
                        scheduleModel.CostPerPerson = (decimal)reader["CostPerPerson"];
                        scheduleModel.CostPerVehicle = (decimal)reader["CostPerVehicle"];
                        scheduleModel.RowVersion = (byte[])reader["RowVersion"];
                    }
                    return scheduleModel;
                }
            }
        }
        public void DeleteDataSchedule(int scheduleId)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Schedule_Delete", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("ScheduleId", SqlDbType.Int)).Value = scheduleId;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteDataScheduleStop(int scheduleStopId)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_ScheduleStop_Delete", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("ScheduleStopId", SqlDbType.Int)).Value = scheduleStopId;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
