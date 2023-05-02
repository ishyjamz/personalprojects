using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Library;

namespace Model_Library
{
    /// <summary>
    /// Presentation layer for cars
    /// </summary>
    public class CarPresentation
    {
        public int CarID { get; set; }
        public string RegNumber { get; set; }
        public int ModelID { get; set; }
        public string ModelName { get; set; } 
        public int MakeID { get; set; }
        public string MakeName { get; set; }
        public int ColourID { get; set; }
        public string ColourName { get; set; }  
        public DateTime RegDate { get; set; }
        public string OwnerFirstName { get; set; }
        public string OwnerSurname { get; set; }
        public int OwnerID { get; set; }
    }
}
