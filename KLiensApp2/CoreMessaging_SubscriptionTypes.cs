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
    
    public partial class CoreMessaging_SubscriptionTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CoreMessaging_SubscriptionTypes()
        {
            this.CoreMessaging_Subscriptions = new HashSet<CoreMessaging_Subscriptions>();
        }
    
        public int SubscriptionTypeId { get; set; }
        public string SubscriptionName { get; set; }
        public string FriendlyName { get; set; }
        public Nullable<int> DesktopModuleId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoreMessaging_Subscriptions> CoreMessaging_Subscriptions { get; set; }
    }
}
