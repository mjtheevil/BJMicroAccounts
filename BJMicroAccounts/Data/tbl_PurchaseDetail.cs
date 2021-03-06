//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tbl_PurchaseDetail
    {
        public long pdetailsId { get; set; }
        public Nullable<long> purchaseID { get; set; }
        public Nullable<long> productID { get; set; }
        public Nullable<decimal> qty { get; set; }
        public Nullable<decimal> weight { get; set; }
        public string unit { get; set; }
        public Nullable<decimal> karat { get; set; }
        public Nullable<decimal> kRate { get; set; }
        public Nullable<decimal> melting { get; set; }
        public Nullable<decimal> purchaseMelting { get; set; }
        public Nullable<decimal> making { get; set; }
        public Nullable<decimal> fine { get; set; }
        public Nullable<decimal> rate { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
    
        public virtual tbl_ItemMaster tbl_ItemMaster { get; set; }
        public virtual tbl_PurchaseMaster tbl_PurchaseMaster { get; set; }
    }
}
