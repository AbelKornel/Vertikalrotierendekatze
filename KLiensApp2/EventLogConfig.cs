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
    
    public partial class EventLogConfig
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EventLogConfig()
        {
            this.EventLog = new HashSet<EventLog>();
        }
    
        public int ID { get; set; }
        public string LogTypeKey { get; set; }
        public Nullable<int> LogTypePortalID { get; set; }
        public bool LoggingIsActive { get; set; }
        public int KeepMostRecent { get; set; }
        public bool EmailNotificationIsActive { get; set; }
        public Nullable<int> NotificationThreshold { get; set; }
        public Nullable<int> NotificationThresholdTime { get; set; }
        public Nullable<int> NotificationThresholdTimeType { get; set; }
        public string MailFromAddress { get; set; }
        public string MailToAddress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventLog> EventLog { get; set; }
        public virtual EventLogTypes EventLogTypes { get; set; }
    }
}
