﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReniumLeague.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RheniumSportsEntities : DbContext
    {
        public RheniumSportsEntities()
            : base("name=RheniumSportsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<MatchesStadium> MatchesStadiums { get; set; }
        public virtual DbSet<Round> Rounds { get; set; }
        public virtual DbSet<Seasone> Seasones { get; set; }
        public virtual DbSet<Stadium> Stadiums { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
    }
}
