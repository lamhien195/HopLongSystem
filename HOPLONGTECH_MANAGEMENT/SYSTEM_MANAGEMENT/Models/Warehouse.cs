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
    
    public partial class Warehouse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Warehouse()
        {
            this.PRODUCTS = new HashSet<PRODUCT>();
            this.TRANSFER_WAREHOUSE_PRODUCTS = new HashSet<TRANSFER_WAREHOUSE_PRODUCTS>();
            this.TRANSFER_WAREHOUSE_PRODUCTS1 = new HashSet<TRANSFER_WAREHOUSE_PRODUCTS>();
        }
    
        public string MA_KHO { get; set; }
        public string TEN_KHO { get; set; }
        public string MO_TA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRODUCT> PRODUCTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSFER_WAREHOUSE_PRODUCTS> TRANSFER_WAREHOUSE_PRODUCTS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSFER_WAREHOUSE_PRODUCTS> TRANSFER_WAREHOUSE_PRODUCTS1 { get; set; }
    }
}
