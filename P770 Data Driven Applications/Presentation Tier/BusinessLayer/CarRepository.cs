using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Validation;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Entity_Library;
using Model_Library;

namespace BusinessLayer
{
    /// <summary>
    /// contains business logic for cars
    /// </summary>
    public class CarRepository
    {
        /// <summary>
        /// populates data grid with full list of cars
        /// </summary>
        /// <returns></returns>
        public List<CarPresentation> List()
        {
            using (var context = new DVLAEntities1())
            {
                var carList = context.Cars.Select(c =>
                new CarPresentation
                {
                    CarID = c.CarId,
                    OwnerID = c.OwnerId,
                    RegNumber = c.RegistrationNumber,
                    MakeName = c.Model.Make.Name,
                    ModelName = c.Model.Name,
                    RegDate = c.RegistrationDate,
                    OwnerFirstName = c.Owner.FirstName,
                    OwnerSurname = c.Owner.LastName,
                    ColourName = c.Colour.Name
                }).OrderBy(c => c.OwnerFirstName).ToList();
                return carList;
            }
        }
        /// <summary>
        /// populates make combobox with all the makes and ids
        /// </summary>
        /// <returns></returns>
        public List<MakePresentation> MakeList()
        {
            using (var context = new DVLAEntities1())
            {
                var makeList = context.Makes.Select(m =>
                new MakePresentation
                {
                    MakeID = m.MakeId,
                    Name = m.Name
                });
                return makeList.OrderBy(m => m.Name).ToList();
            }
        }
        /// <summary>
        /// Populates model cmb with only models that belong to make
        /// </summary>
        /// <param name="makeId"></param>
        /// <returns></returns>
        public List<ModelPresentation> FilteredModelList(int makeId)
        {
            using (var context = new DVLAEntities1())
            {
                var filteredModelList = context.Models.Select(m =>
                new ModelPresentation
                {
                    ModelId = m.ModelId,
                    Name = m.Name,
                    MakeId = m.MakeId
                }).Where(m => m.MakeId == makeId);
                return filteredModelList.OrderBy(m => m.Name).ToList();
            }
        }
        /// <summary>
        /// populates model cmb with all models and ids
        /// </summary>
        /// <returns></returns>
        public List<ModelPresentation> ModelList()
        {
            using (var context = new DVLAEntities1())
            {
                var modelList = context.Models.Select(m =>
                new ModelPresentation
                {
                    ModelId = m.ModelId,
                    Name = m.Name
                });
                return modelList.OrderBy(c => c.Name).ToList();
            }
        }
        /// <summary>
        /// populates colour cmb with all colours and ids
        /// </summary>
        /// <returns></returns>
        public List<ColourPresentation> ColourList()
        {
            using (var context = new DVLAEntities1())
            {
                var colourList = context.Colours.Select(c =>
                new ColourPresentation
                {
                    ColourId = c.ColourId,
                    Name = c.Name
                });
                return colourList.OrderBy(c => c.Name).ToList();
            }
        }
        /// <summary>
        /// Populates data grid of cars with only cars matching the filter
        /// </summary>
        /// <param name="regNumber"></param>
        /// <param name="model"></param>
        /// <param name="make"></param>
        /// <param name="colour"></param>
        /// <param name="ownerFirstName"></param>
        /// <param name="ownerSurname"></param>
        /// <returns></returns>
        public List<CarPresentation> Filter(string regNumber, string model,
            string make, string colour, string ownerFirstName,
            string ownerSurname)
        {
            using (var context = new DVLAEntities1())
            {
                var filterList = context.Cars.Select(c =>
                new CarPresentation
                {
                    CarID = c.CarId,
                    OwnerID = c.OwnerId,
                    RegNumber = c.RegistrationNumber,
                    MakeName = c.Model.Make.Name,
                    ModelName = c.Model.Name,
                    RegDate = c.RegistrationDate,
                    OwnerFirstName = c.Owner.FirstName,
                    OwnerSurname = c.Owner.LastName,
                    ColourName = c.Colour.Name

                });
                if (!String.IsNullOrWhiteSpace(regNumber))
                {
                    filterList = filterList.Where(c => c.RegNumber == regNumber);
                }
                if (!String.IsNullOrWhiteSpace(model))
                {
                    filterList = filterList.Where(c => c.ModelName == model);
                }
                if (!String.IsNullOrWhiteSpace(make))
                {
                    filterList = filterList.Where(c => c.MakeName == make);
                }
                if (!String.IsNullOrWhiteSpace(colour))
                {
                    filterList = filterList.Where(c => c.ColourName == colour);
                }
                if (!String.IsNullOrWhiteSpace(ownerFirstName))
                {
                    filterList = filterList.Where(c => c.OwnerFirstName == ownerFirstName);
                }
                if (!String.IsNullOrWhiteSpace(ownerSurname))
                {
                    filterList = filterList.Where(c => c.OwnerSurname == ownerSurname);
                }
                return filterList.OrderBy(c => c.OwnerFirstName).ToList();
            }
        }
        /// <summary>
        /// Updates car details in database
        /// </summary>
        /// <param name="carModel"></param>
        /// <returns></returns>
        public Car UpdateCarDetails(CarPresentation carModel)
        {
            using (var context = new DVLAEntities1())
            {
                Car car = new Car();
                car = context.Cars.Find(carModel.CarID);
                car.OwnerId = carModel.OwnerID;
                car.ModelId = carModel.ModelID;
                car.RegistrationNumber = carModel.RegNumber;
                car.ColourId = carModel.ColourID;
                car.RegistrationDate = carModel.RegDate;
                context.SaveChanges();
                return car;
            }
        }
        /// <summary>
        /// adds new car to database
        /// </summary>
        /// <param name="carModel"></param>
        /// <returns></returns>
        public Car AddNewCar(CarPresentation carModel)
        {
            using (var context = new DVLAEntities1())
            {
                Car car = new Car();
                car.OwnerId = carModel.OwnerID;
                car.ModelId = carModel.ModelID;
                car.RegistrationNumber = carModel.RegNumber;
                car.ColourId = carModel.ColourID;
                car.RegistrationDate = carModel.RegDate;
                context.Cars.Add(car);
                context.SaveChanges();
                return car ;
            }
        }
    }
}
 

        
 
