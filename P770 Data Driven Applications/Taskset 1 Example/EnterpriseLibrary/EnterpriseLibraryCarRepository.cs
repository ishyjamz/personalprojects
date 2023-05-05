using System;
using System.Collections.Generic;
using System.Data;
using Interfaces;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Models;

namespace EnterpriseLibrary
{
    /// <summary>
    /// Repository providing basic data access functions for the
    /// <see cref="Car"/> class, using the Enterprise Library Data Access
    /// Application Block to access a database.
    /// </summary>
    public class EnterpriseLibraryCarRepository :
        ICarRepository
    {
        /// <summary>
        /// Returns a list of all car records stored in the database.
        /// </summary>
        public IReadOnlyList<Car> List()
        {
            // Create a database object using the default connection string
            // specified in App.config.
            var db = new DatabaseProviderFactory().CreateDefault();

            // Set up the command
            // Use a data reader to process 1 row of the result set at
            // a time. The connection is opened automatically.
            using (var cmd = db.GetStoredProcCommand("dbo.usp_CarList"))
            using (var reader = db.ExecuteReader(cmd))
            {
                var cars = new List<Car>();

                while (reader.Read())
                {
                    cars.Add(CarFromRecord(reader));
                }

                return cars;
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
            // Create a database object using the default connection string
            // specified in App.config.
            var db = new DatabaseProviderFactory().CreateDefault();

            using (var cmd = db.GetStoredProcCommand("dbo.usp_CarInsert"))
            {
                // Use DiscoverParameters to quickly add all of the parameters
                // to the command with the correct data types/directions etc.
                db.DiscoverParameters(cmd);

                // Set the parameter values.
                db.SetParameterValue(cmd, "RegNumber", entity.RegNumber);
                db.SetParameterValue(cmd, "Make", entity.Make);
                db.SetParameterValue(cmd, "Model", entity.Model);
                db.SetParameterValue(cmd, "RegistrationDate", entity.RegistrationDate);
                
                // Execute the command.
                db.ExecuteNonQuery(cmd);

                // Get the value of the output parameter.
                entity.CarID = (int)db.GetParameterValue(cmd, "CarID");
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
