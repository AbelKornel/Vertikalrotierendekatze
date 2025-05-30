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
    
    public partial class ExportImportJobs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ExportImportJobs()
        {
            this.ExportImportCheckpoints = new HashSet<ExportImportCheckpoints>();
            this.ExportImportJobLogs = new HashSet<ExportImportJobLogs>();
        }
    
        public int JobId { get; set; }
        public int PortalId { get; set; }
        public int JobType { get; set; }
        public int JobStatus { get; set; }
        public bool IsCancelled { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreatedByUserID { get; set; }
        public System.DateTime CreatedOnDate { get; set; }
        public System.DateTime LastModifiedOnDate { get; set; }
        public Nullable<System.DateTime> CompletedOnDate { get; set; }
        public string Directory { get; set; }
        public string JobObject { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExportImportCheckpoints> ExportImportCheckpoints { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExportImportJobLogs> ExportImportJobLogs { get; set; }
    }
}
