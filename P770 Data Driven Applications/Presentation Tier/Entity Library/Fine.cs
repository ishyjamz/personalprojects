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
    
    public partial class Fine
    {
        public int SightingId { get; set; }
        public System.DateTime DateIssued { get; set; }
        public Nullable<System.DateTime> DatePaid { get; set; }
    
        public virtual Sighting Sighting { get; set; }
    }
}
