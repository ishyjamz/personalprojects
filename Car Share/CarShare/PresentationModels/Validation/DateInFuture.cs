using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationModels.Validation
{
    /// <summary>
    /// Validation attribute to ensure that users can only select future dates 
    /// when creating a booking or journey
    /// </summary>
    public class DateInFuture: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return (DateTime)value > DateTime.Today;
        }
    }
}
