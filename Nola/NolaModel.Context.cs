﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nola
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NolaDBEntities : DbContext
    {
        public NolaDBEntities()
            : base("name=NolaDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Expense> Expense { get; set; }
        public virtual DbSet<Purchase> Purchase { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<viewExpenseCar> viewExpenseCar { get; set; }
        public virtual DbSet<viewPurchaseCar> viewPurchaseCar { get; set; }
        public virtual DbSet<viewSaleCar> viewSaleCar { get; set; }
        public virtual DbSet<viewCheckPurchase> viewCheckPurchase { get; set; }
    }
}
