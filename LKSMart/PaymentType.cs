//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LKSMart
{
    using System;
    using System.Collections.Generic;
    
    public partial class PaymentType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaymentType()
        {
            this.HeaderTransactions = new HashSet<HeaderTransaction>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public System.DateTime created_at { get; set; }
        public Nullable<System.DateTime> last_updated_at { get; set; }
        public Nullable<System.DateTime> deleted_at { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HeaderTransaction> HeaderTransactions { get; set; }
    }
}
