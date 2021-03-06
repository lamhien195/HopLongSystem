//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SYSTEM_MANAGEMENT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            this.BANG_CHAM_CONG = new HashSet<BANG_CHAM_CONG>();
            this.BANG_LUONG = new HashSet<BANG_LUONG>();
            this.CUSTOMERS = new HashSet<CUSTOMER>();
            this.DEPARTMENTS = new HashSet<DEPARTMENT>();
            this.GHI_CHU_CONG_VIEC = new HashSet<GHI_CHU_CONG_VIEC>();
            this.MANAGE_SALES_AND_CUSTOMERS = new HashSet<MANAGE_SALES_AND_CUSTOMERS>();
            this.PURCHASE_ORDER = new HashSet<PURCHASE_ORDER>();
            this.SUPPLIERS = new HashSet<SUPPLIER>();
            this.USER_METAS = new HashSet<USER_METAS>();
            this.USER_PERMISSION = new HashSet<USER_PERMISSION>();
            this.HOLD_PRODUCT_DETAILS = new HashSet<HOLD_PRODUCT_DETAILS>();
        }
    
        public int USER_ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public string FULLNAME { get; set; }
        public string EMAIL { get; set; }
        public string AVATAR { get; set; }
        public Nullable<byte> IS_ADMIN { get; set; }
        public Nullable<byte> ALLOWED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANG_CHAM_CONG> BANG_CHAM_CONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANG_LUONG> BANG_LUONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUSTOMER> CUSTOMERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEPARTMENT> DEPARTMENTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GHI_CHU_CONG_VIEC> GHI_CHU_CONG_VIEC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MANAGE_SALES_AND_CUSTOMERS> MANAGE_SALES_AND_CUSTOMERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PURCHASE_ORDER> PURCHASE_ORDER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUPPLIER> SUPPLIERS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_METAS> USER_METAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_PERMISSION> USER_PERMISSION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOLD_PRODUCT_DETAILS> HOLD_PRODUCT_DETAILS { get; set; }
    }
}
