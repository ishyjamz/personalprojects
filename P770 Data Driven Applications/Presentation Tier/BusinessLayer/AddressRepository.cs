using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Library;
using Model_Library;

namespace BusinessLayer
{
    /// <summary>
    /// contains business logic for addresses
    /// </summary>
    public class AddressRepository
    {
        /// <summary>
        /// Populates address data grid with addresses based on filters
        /// </summary>
        /// <param name="line1"></param>
        /// <param name="city"></param>
        /// <param name="country"></param>
        /// <param name="postcode"></param>
        /// <returns></returns>
        public List<AddressPresentation> SearchAddress(string line1, string city, 
            string country, string postcode)
        {
            using (var context = new DVLAEntities1())
            {
                var searchAddressList = context.Addresses.Select(a =>
                new AddressPresentation
                {
                    AddressId = a.AddressId,
                    Line1 = a.Line1,
                    Line2 = a.Line2,
                    Line3 = a.Line3,
                    City = a.City,
                    County = a.County,
                    Country = a.Country,
                    PostalCode = a.PostalCode
                });
                if (!String.IsNullOrWhiteSpace(line1))
                {
                    searchAddressList = searchAddressList.Where(a => a.Line1 == line1);
                }
                if (!String.IsNullOrWhiteSpace(city))
                {
                    searchAddressList = searchAddressList.Where(o => o.City == city);
                }
                if (!String.IsNullOrWhiteSpace(country))
                {
                    searchAddressList = searchAddressList.Where(o => o.Country == country);
                }
                if (!String.IsNullOrWhiteSpace(postcode))
                {
                    searchAddressList = searchAddressList.Where(o => o.PostalCode == postcode);
                }
                return searchAddressList.OrderBy(c => c.City).ToList();
            }
        }
    }
}
