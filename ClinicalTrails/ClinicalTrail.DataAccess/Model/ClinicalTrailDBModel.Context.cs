﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicalTrail.DataAccess.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ClinicalTrialsDBEntities : DbContext
    {
        public ClinicalTrialsDBEntities()
            : base("name=ClinicalTrialsDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CenterMaster> CenterMasters { get; set; }
        public virtual DbSet<InvestigatorMaster> InvestigatorMasters { get; set; }
        public virtual DbSet<VendorMaster> VendorMasters { get; set; }
    }
}
