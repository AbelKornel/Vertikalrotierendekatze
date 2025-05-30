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
    
    public partial class ContentItems
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContentItems()
        {
            this.ContentItems_MetaData = new HashSet<ContentItems_MetaData>();
            this.ContentItems_Tags = new HashSet<ContentItems_Tags>();
            this.ContentWorkflowLogs = new HashSet<ContentWorkflowLogs>();
            this.Files = new HashSet<Files>();
            this.Modules = new HashSet<Modules>();
            this.Tabs = new HashSet<Tabs>();
        }
    
        public int ContentItemID { get; set; }
        public string Content { get; set; }
        public int ContentTypeID { get; set; }
        public int TabID { get; set; }
        public int ModuleID { get; set; }
        public string ContentKey { get; set; }
        public bool Indexed { get; set; }
        public Nullable<int> CreatedByUserID { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> LastModifiedByUserID { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
        public Nullable<int> StateID { get; set; }
    
        public virtual ContentWorkflowStates ContentWorkflowStates { get; set; }
        public virtual ContentTypes ContentTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContentItems_MetaData> ContentItems_MetaData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContentItems_Tags> ContentItems_Tags { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContentWorkflowLogs> ContentWorkflowLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Files> Files { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Modules> Modules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tabs> Tabs { get; set; }
    }
}
