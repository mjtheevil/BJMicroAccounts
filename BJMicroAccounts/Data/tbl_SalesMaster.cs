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
    
    public partial class tbl_SalesMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_SalesMaster()
        {
            this.tbl_SalesDetails = new HashSet<tbl_SalesDetails>();
        }
    
        public long sId { get; set; }
        public string billNo { get; set; }
        public Nullable<long> ledgerId { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<decimal> totalWeight { get; set; }
        public string unit { get; set; }
        public Nullable<decimal> totalKarat { get; set; }
        public Nullable<decimal> totalMaking { get; set; }
        public Nullable<decimal> totalAmt { get; set; }
        public string remarks { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
    
        public virtual tbl_AccLedger tbl_AccLedger { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_SalesDetails> tbl_SalesDetails { get; set; }
    }
}
