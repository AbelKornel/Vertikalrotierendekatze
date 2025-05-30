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
    
    public partial class ContentWorkflows
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContentWorkflows()
        {
            this.ContentWorkflowLogs = new HashSet<ContentWorkflowLogs>();
            this.ContentWorkflowSources = new HashSet<ContentWorkflowSources>();
            this.ContentWorkflowStates = new HashSet<ContentWorkflowStates>();
            this.Folders = new HashSet<Folders>();
        }
    
        public int WorkflowID { get; set; }
        public Nullable<int> PortalID { get; set; }
        public string WorkflowName { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
        public bool StartAfterCreating { get; set; }
        public bool StartAfterEditing { get; set; }
        public bool DispositionEnabled { get; set; }
        public bool IsSystem { get; set; }
        public string WorkflowKey { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContentWorkflowLogs> ContentWorkflowLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContentWorkflowSources> ContentWorkflowSources { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContentWorkflowStates> ContentWorkflowStates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Folders> Folders { get; set; }
    }
}
