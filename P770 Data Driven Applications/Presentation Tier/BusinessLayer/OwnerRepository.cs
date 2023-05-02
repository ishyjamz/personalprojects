using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Library;
using Model_Library;

namespace BusinessLayer
{
    /// <summary>
    /// Contains all business logic for owners
    /// </summary>
    public class OwnerRepository
    {
        /// <summary>
        /// Populates Owner grid with the values corresponding to the filters 
        /// in the parameters
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="surname"></param>
        /// <param name="line1"></param>
        /// <param name="city"></param>
        /// <param name="country"></param>
        /// <param name="postcode"></param>
        /// <returns></returns>
        public List<OwnerPresentation> SearchOwner(string firstName, string surname,
            string line1, string city, string country, string postcode)
        {
            using (var context = new DVLAEntities1())
            {
                var searchOwnerList = context.Owners.Select(o =>
                new OwnerPresentation
                {
                    OwnerId = o.OwnerId,
                    AddressId = o.AddressId,
                    FirstName = o.FirstName,
                    LastName = o.LastName,
                    DateOfBirth = o.DateOfBirth,
                    Line1 = o.Address.Line1,
                    City = o.Address.City,
                    Country = o.Address.Country,
                    Postcode = o.Address.PostalCode,
                    RowVersion = o.RowVersion
                });
                if (!String.IsNullOrWhiteSpace(firstName))
                {
                    searchOwnerList = searchOwnerList.Where(o => o.FirstName == firstName);
                }
                if (!String.IsNullOrWhiteSpace(surname))
                {
                    searchOwnerList = searchOwnerList.Where(o => o.LastName == surname);
                }                
                if (!String.IsNullOrWhiteSpace(line1))
                {
                    searchOwnerList = searchOwnerList.Where(o => o.Line1 == line1);
                }
                if (!String.IsNullOrWhiteSpace(city))
                {
                    searchOwnerList = searchOwnerList.Where(o => o.City == city);
                }
                if (!String.IsNullOrWhiteSpace(country))
                {
                    searchOwnerList = searchOwnerList.Where(o => o.Country == country);
                }
                if (!String.IsNullOrWhiteSpace(postcode))
                {
                    searchOwnerList = searchOwnerList.Where(o => o.Postcode == postcode);
                }
                return searchOwnerList.OrderBy(c => c.FirstName).ToList();
            }
        }
        /// <summary>
        /// Updates owner details to the database
        /// </summary>
        /// <param name="ownerModel"></param>
        /// <returns></returns>
        public Owner UpdateOwnerDetails(OwnerPresentation ownerModel)
        {
            using (var context = new DVLAEntities1())
            {
                Owner owner = new Owner();
                owner = context.Owners.Find(ownerModel.OwnerId);
                context.Entry(owner).Property(o => o.RowVersion).OriginalValue = ownerModel.RowVersion;
                owner.FirstName = ownerModel.FirstName;
                owner.LastName = ownerModel.LastName;
                owner.AddressId = ownerModel.AddressId;
                owner.DateOfBirth = ownerModel.DateOfBirth;
                try
                {
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return null;
                }
                return owner;
            }
        }
        /// <summary>
        /// adds new owner to database
        /// </summary>
        /// <param name="ownerModel"></param>
        /// <returns></returns>
        public Owner AddNewOwner(OwnerPresentation ownerModel)
        {
            using (var context = new DVLAEntities1())
            {
                Owner owner = new Owner();
                owner.OwnerId = ownerModel.OwnerId;
                owner.FirstName = ownerModel.FirstName;
                owner.LastName = ownerModel.LastName;
                owner.AddressId = ownerModel.AddressId;
                owner.DateOfBirth = ownerModel.DateOfBirth;
                context.Owners.Add(owner);
                context.SaveChanges();
                return owner;
            }
        }
        /// <summary>
        /// Populates full list of owners in datagrid
        /// </summary>
        /// <returns></returns>
        public List<OwnerPresentation> List()
        {
            using (var context = new DVLAEntities1())
            {
                var ownerList = context.Owners.Select(o =>
                new OwnerPresentation
                {
                    OwnerId = o.OwnerId,
                    AddressId = o.AddressId,
                    FirstName = o.FirstName,
                    LastName = o.LastName,
                    DateOfBirth = o.DateOfBirth,
                    Line1 = o.Address.Line1,
                    City = o.Address.City,
                    Country = o.Address.Country,
                    Postcode = o.Address.PostalCode,
                    RowVersion = o.RowVersion
                }).OrderBy(c => c.FirstName).ToList();
                return ownerList;
            }
        }
        /// <summary>
        /// Shows all cars for owners
        /// </summary>
        /// <param name="ownerID"></param>
        /// <returns></returns>
        public List<CarPresentation> FindCar(int ownerID)
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
                }).Where(o => o.OwnerID == ownerID);
                return carList.OrderBy(c => c.RegNumber).ToList();
            }
        }
    }
}
