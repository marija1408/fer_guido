﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Baza
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GuidoEntities : DbContext
    {
        public GuidoEntities()
            : base("name=GuidoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Place> Place { get; set; }
        public virtual DbSet<Route> Route { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}