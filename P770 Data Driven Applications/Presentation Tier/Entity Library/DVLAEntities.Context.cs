﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DVLAEntities1 : DbContext
    {
        public DVLAEntities1()
            : base("name=DVLAEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Camera> Cameras { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Colour> Colours { get; set; }
        public virtual DbSet<DrivingLicence> DrivingLicences { get; set; }
        public virtual DbSet<Fine> Fines { get; set; }
        public virtual DbSet<LicenceCategory> LicenceCategories { get; set; }
        public virtual DbSet<LicenceEntitlement> LicenceEntitlements { get; set; }
        public virtual DbSet<Make> Makes { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
        public virtual DbSet<Sighting> Sightings { get; set; }
        public virtual DbSet<SpeedCamera> SpeedCameras { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TrafficLightCamera> TrafficLightCameras { get; set; }
    }
}