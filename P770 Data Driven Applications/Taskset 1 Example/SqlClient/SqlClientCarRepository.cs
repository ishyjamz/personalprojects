using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Interfaces;
using Models;

namespace SqlClient
{
    /// <summary>
    /// Repository providing basic data access functions for the
    /// <see cref="Car"/> class, using classes in the
    /// <c>System.Data.SqlClient</c> namespace to access a database.
    /// </summary>
    public class SqlClientCarRepository :
        ICarRepository
    {
        /// <summary>
        /// The connection string to be used by methods within the class.
        /// </summary>
        private string _ConnectionString = ConfigurationManager
            .ConnectionStrings["DDAConnection"].ConnectionString;

        /// <summary>
        /// Returns a list of all car records stored in the database.
        /// </summary>
        public IReadOnlyList<Car> List()
        {
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_CarList", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                // Use a data reader to process 1 row of the result set at
                // a time.
                using (var reader = cmd.ExecuteReader())
                {
                    var cars = new List<Car>();

                    while (reader.Read())
                    {
                        cars.Add(CarFromRecord(reader));
                    }

                    return cars;
                }
            }
        }

        /// <summary>
        /// Inserts a new car record into the database.
        /// </summary>
        /// <param name="entity">The car to insert.</param>
        /// <remarks>Does not include any error handling for the case where the
        /// car already exists.</remarks>
        public void Insert(
           Car entity)
        {
            // Create the connection
            // Create the command and set its command text to the stored proc name,
            // and set the command to run on the connection
            using (var conn = new SqlConnection(this._ConnectionString))
            using (var cmd = new SqlCommand("dbo.usp_CarInsert", conn))
            {
                // Tell the command we wish to run a stored procedure rather than run free SQL
                cmd.CommandType = CommandType.StoredProcedure;

                // Add the parameters
                cmd.Parameters.Add("CarID", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("RegNumber", SqlDbType.NVarChar, 10).Value = entity.RegNumber;
                cmd.Parameters.Add("Make", SqlDbType.NVarChar, 50).Value = entity.Make;
                cmd.Parameters.Add("Model", SqlDbType.NVarChar, 50).Value = entity.Model;
                cmd.Parameters.Add("RegistrationDate", SqlDbType.SmallDateTime).Value = entity.RegistrationDate;

                // Open the connection
                conn.Open();
                
                // Execute the query
                cmd.ExecuteNonQuery();

                // Get the value of the first (output) parameter
                entity.CarID = (int)cmd.Parameters["CarID"].Value;
            }
        }

        /// <summary>
        /// Returns a new <see cref="Car"/> object, initialised from the given
        /// record.
        /// </summary>
        private static Car CarFromRecord(
            IDataRecord record)
        {
            return new Car
            {
                CarID = (int)record["CarID"],
                RegNumber = (string)record["RegNumber"],
                Make = (string)record["Make"],
                Model = (string)record["Model"],
                RegistrationDate = (DateTime)record["RegistrationDate"]
            };
        }
    }
}
