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
    
    public partial class tbl_LedgerDetails
    {
        public long id { get; set; }
        public Nullable<long> ledgerId { get; set; }
        public string address { get; set; }
        public Nullable<decimal> contact { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
    
        public virtual tbl_AccLedger tbl_AccLedger { get; set; }
    }
}
