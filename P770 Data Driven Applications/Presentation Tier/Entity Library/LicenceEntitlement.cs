//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity_Library
{
    using System;
    using System.Collections.Generic;
    
    public partial class LicenceEntitlement
    {
        public int OwnerId { get; set; }
        public int LicenceCategoryId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime ExpirationDate { get; set; }
    
        public virtual DrivingLicence DrivingLicence { get; set; }
        public virtual LicenceCategory LicenceCategory { get; set; }
    }
}
