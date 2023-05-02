using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Library
{
    /// <summary>
    /// Presentation Layer model for car models
    /// </summary>
    public class ModelPresentation
    {
        public int ModelId { get; set; }
        public int? MakeId { get; set; }
        public string Name { get; set; }
    }
}
