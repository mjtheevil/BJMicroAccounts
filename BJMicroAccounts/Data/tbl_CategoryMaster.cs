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
    
    public partial class tbl_CategoryMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CategoryMaster()
        {
            this.tbl_ItemMaster = new HashSet<tbl_ItemMaster>();
        }
    
        public long cId { get; set; }
        public string cName { get; set; }
        public string prefix { get; set; }
        public Nullable<System.DateTime> createdDate { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ItemMaster> tbl_ItemMaster { get; set; }
    }
}
