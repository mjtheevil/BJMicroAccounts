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
    
    public partial class tbl_UserLogiln
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_UserLogiln()
        {
            this.tbl_TransactionMaster = new HashSet<tbl_TransactionMaster>();
        }
    
        public long id { get; set; }
        public Nullable<long> userId { get; set; }
        public string loginId { get; set; }
        public string password { get; set; }
        public Nullable<System.DateTime> lastLogin { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TransactionMaster> tbl_TransactionMaster { get; set; }
        public virtual tbl_UserProfile tbl_UserProfile { get; set; }
    }
}
