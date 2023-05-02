using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Library
{
    /// <summary>
    /// Presentation Layer model for owners
    /// </summary>
    public class OwnerPresentation
    {
        public int OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public int AddressId { get; set; }
        public string City { get; set; }    
        public string Line1 { get; set; }
        public string Country { get; set; } 
        public string Postcode { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
