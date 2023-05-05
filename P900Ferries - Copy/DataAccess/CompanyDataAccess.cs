using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessModels.Models.CompanyModels;
using DataAccessModels.Models.FerryModels;
using DataAccessModels.Models.ScheduleModels;

namespace DataAccess
{
    public class CompanyDataAccess
    {
        private string _ConnectionString = ConfigurationManager
            .ConnectionStrings["DefaultConnection"].ConnectionString;

        public CompanyDataModel UpdateDataCompany(CompanyDataModel company)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Company_Update", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("Name", SqlDbType.NVarChar)).Value = company.Name;
                cmd.Parameters.Add(new SqlParameter("CompanyId", SqlDbType.Int)).Value = company.CompanyId;
                cmd.Parameters.Add(new SqlParameter("RowVersion", SqlDbType.Timestamp)).Value = company.RowVersion;

                conn.Open();
                var companyModel = new CompanyDataModel();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        companyModel.Name = (string)reader["Name"];
                        companyModel.CompanyId = (int)reader["CompanyId"];
                        companyModel.RowVersion = (byte[])reader["RowVersion"];
                    }
                    return companyModel;
                }
            }
        }
        public CompanyDataModel GetDataCompanyById(int id)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Company_Get", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("CompanyId", SqlDbType.Int)).Value = id;
                conn.Open();
                var companyModel = new CompanyDataModel();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        companyModel.CompanyId = (int)reader["CompanyId"];
                        companyModel.Name = (string)reader["Name"];
                        companyModel.RowVersion = (byte[])reader["RowVersion"];
                    }
                }
                return companyModel;
            }
        }

        public List<CompanyDataModel> GetCompanyList()
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Company_List", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    var list = new List<CompanyDataModel>();
                    while (reader.Read())
                    {
                        list.Add(CompanyFromRecord(reader));
                    }
                    return list;
                }
            }
        }
        private static CompanyDataModel CompanyFromRecord(
                  IDataRecord record)
        {
            return new CompanyDataModel()
            {
                CompanyId = (int)record["CompanyId"],
                Name = (string)record["CompanyName"]
            };
        }
        public void AddCompanyToDatabase(CompanyDataModel companyData)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Company_Insert", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("Name", SqlDbType.NVarChar)).Value = companyData.Name;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public List<FerryDataForGrid> ListFerriesForGrid(int companyId)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Company_ListFerry", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("CompanyId", SqlDbType.Int)).Value = companyId;
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    var list = new List<FerryDataForGrid>();
                    while (reader.Read())
                    {
                        list.Add(FerryFromRecord(reader));
                    }
                    return list;
                }
            }
        }
        private static FerryDataForGrid FerryFromRecord(
         IDataRecord record)
        {
            return new FerryDataForGrid()
            {
               CompanyId = (int)record["CompanyId"],
               FerryId = (int)record["FerryId"],
               FerryName = (string)record["Name"]
            };
        }
        public void DeleteDataCompany(int companyId)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Company_Delete", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("CompanyId", SqlDbType.Int)).Value = companyId;
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public List<CompanyDataModel> ListCompanies(string companyName)
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_Company_ListSearch", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (!String.IsNullOrWhiteSpace(companyName))
                {
                    cmd.Parameters.Add(new SqlParameter("CompanyName", SqlDbType.NVarChar)).Value = companyName;
                }
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    var list = new List<CompanyDataModel>();
                    while (reader.Read())
                    {
                        list.Add(CompanyFromRecord(reader));
                    }
                    return list;
                }
            }
        }
    }
}
