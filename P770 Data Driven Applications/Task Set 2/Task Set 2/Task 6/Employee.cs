using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class Employee
    {
        public int EmployeeID { get; set; } 
        public string FirstName { get; set; }
        public string Surname { get; set; } 
        public string Address { get; set; } 
        public string Postcode { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
        public byte[] RowVersion { get; set; }  
    }
}
