using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DataAccessModels.Models.FerryModels;
using System.ComponentModel.Design;

namespace DataAccess
{
    public class FerryDataAccess
    {
        private string _ConnectionString = ConfigurationManager
            .ConnectionStrings["DefaultConnection"].ConnectionString;
        public List<ScheduleSubDataModel> ListFerries(string ferryName, string companyName)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Ferry_ListSearch", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (!String.IsNullOrWhiteSpace(ferryName))
                {
                    cmd.Parameters.Add(new SqlParameter("FerryName", SqlDbType.NVarChar)).Value = ferryName;

                }
                if (!String.IsNullOrWhiteSpace(companyName))
                {
                    cmd.Parameters.Add(new SqlParameter("CompanyName", SqlDbType.NVarChar)).Value = companyName;
                }
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    var list = new List<ScheduleSubDataModel>();
                    while (reader.Read())
                    {
                        list.Add(FerryFromRecord(reader));
                    }
                    return list;
                }
            }
        }
        public FerryDataModel UpdateDataFerry(FerryDataModel ferry)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Ferry_Update", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("Name", SqlDbType.NVarChar)).Value = ferry.Name;
                cmd.Parameters.Add(new SqlParameter("CompanyId", SqlDbType.Int)).Value = ferry.CompanyId;
                cmd.Parameters.Add(new SqlParameter("FerryId", SqlDbType.Int)).Value = ferry.FerryId;
                cmd.Parameters.Add(new SqlParameter("RowVersion", SqlDbType.Timestamp)).Value = ferry.RowVersion;

                conn.Open();
                var ferryModel = new FerryDataModel();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ferryModel.FerryId = (int)reader["FerryId"];
                        ferryModel.Name = (string)reader["FerryName"];
                        ferryModel.CompanyId = (int)reader["CompanyId"];
                        ferryModel.RowVersion = (byte[])reader["RowVersion"];
                    }
                    return ferryModel;
                }
            }
        }
        public ScheduleSubDataModel GetFerryById(int id)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Ferry_Get", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("FerryId", SqlDbType.Int)).Value = id;
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return new ScheduleSubDataModel
                        {
                            FerryId = (int)reader["FerryId"],
                            FerryName = (string)reader["FerryName"],
                            CompanyName = (string)reader["CompanyName"],
                        };
                    }
                }
                return null;
            }
        }
        public FerryDataModel GetDataFerryById(int id)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Ferry_Get", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("FerryId", SqlDbType.Int)).Value = id;
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return new FerryDataModel
                        {
                            FerryId = (int)reader["FerryId"],
                            CompanyId = (int)reader["CompanyId"],
                            Name = (string)reader["FerryName"],
                            RowVersion = (byte[])reader["RowVersion"]
                        };
                    }
                }
                return null;
            }
        }
        //private static FerryDataModel FerryViewFromRecord(IDataRecord record)
        //{
        //    return new FerryDataModel()
        //    {
        //        FerryId = (int)record["FerryId"],
        //        Name = (string)record["Name"],
        //        CompanyId = (int)record["CompanyId"]
        //    };
        //}
        private static ScheduleSubDataModel FerryFromRecord(
           IDataRecord record)
        {
            return new ScheduleSubDataModel()
            {
                FerryId = (int)record["FerryId"],
                FerryName = (string)record["FerryName"],
                CompanyName = (string)record["CompanyName"],
            };
        }
        public void AddFerryToDatabase(string ferryName, int companyId)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Ferry_Insert", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("Name", SqlDbType.NVarChar)).Value = ferryName;
                cmd.Parameters.Add(new SqlParameter("CompanyId", SqlDbType.Int)).Value = companyId;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteDataFerry(int ferryId)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Ferry_Delete", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("FerryId", SqlDbType.Int)).Value = ferryId;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
