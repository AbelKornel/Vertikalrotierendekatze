//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KLiensApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class hcc_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hcc_User()
        {
            this.hcc_UserXContact = new HashSet<hcc_UserXContact>();
        }
    
        public string bvin { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public int TaxExempt { get; set; }
        public System.DateTime CreationDate { get; set; }
        public System.DateTime LastLoginDate { get; set; }
        public string Comment { get; set; }
        public string AddressBook { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public int Locked { get; set; }
        public System.DateTime LockedUntil { get; set; }
        public int FailedLoginCount { get; set; }
        public string Phones { get; set; }
        public string PricingGroup { get; set; }
        public string CustomQuestionAnswers { get; set; }
        public long StoreId { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hcc_UserXContact> hcc_UserXContact { get; set; }
    }
}
