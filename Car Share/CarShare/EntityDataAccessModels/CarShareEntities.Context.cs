﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityDataAccessModels
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CarShareEntities : DbContext
    {
        public CarShareEntities()
            : base("name=CarShareEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<DriverJourney> DriverJourneys { get; set; }
        public virtual DbSet<DriverStop> DriverStops { get; set; }
        public virtual DbSet<JourneyStop> JourneyStops { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<PassengerJourney> PassengerJourneys { get; set; }
        public virtual DbSet<PassengerJourneyStatus> PassengerJourneyStatus1 { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
