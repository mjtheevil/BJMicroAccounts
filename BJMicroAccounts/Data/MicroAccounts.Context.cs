﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BJMicroAccounts.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MicroAccountsEntities1 : DbContext
    {
        public MicroAccountsEntities1()
            : base("name=MicroAccountsEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DailyRate> DailyRates { get; set; }
        public virtual DbSet<tbl_AccGroup> tbl_AccGroup { get; set; }
        public virtual DbSet<tbl_AccLedger> tbl_AccLedger { get; set; }
        public virtual DbSet<tbl_CategoryMaster> tbl_CategoryMaster { get; set; }
        public virtual DbSet<tbl_Entry> tbl_Entry { get; set; }
        public virtual DbSet<tbl_EntryDetails> tbl_EntryDetails { get; set; }
        public virtual DbSet<tbl_ItemMaster> tbl_ItemMaster { get; set; }
        public virtual DbSet<tbl_LedgerDetails> tbl_LedgerDetails { get; set; }
        public virtual DbSet<tbl_SalesDetails> tbl_SalesDetails { get; set; }
        public virtual DbSet<tbl_SalesMaster> tbl_SalesMaster { get; set; }
        public virtual DbSet<tbl_StockItemDetails> tbl_StockItemDetails { get; set; }
        public virtual DbSet<tbl_TransactionMaster> tbl_TransactionMaster { get; set; }
        public virtual DbSet<tbl_UserLogiln> tbl_UserLogiln { get; set; }
        public virtual DbSet<tbl_UserProfile> tbl_UserProfile { get; set; }
        public virtual DbSet<tbl_TaxDetail> tbl_TaxDetail { get; set; }
        public virtual DbSet<tbl_TaxMaster> tbl_TaxMaster { get; set; }
        public virtual DbSet<tbl_PurchaseDetail> tbl_PurchaseDetail { get; set; }
        public virtual DbSet<tbl_PurchaseMaster> tbl_PurchaseMaster { get; set; }
    }
}
