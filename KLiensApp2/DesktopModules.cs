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
    
    public partial class DesktopModules
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DesktopModules()
        {
            this.CoreMessaging_NotificationTypes = new HashSet<CoreMessaging_NotificationTypes>();
            this.ModuleDefinitions = new HashSet<ModuleDefinitions>();
            this.PortalDesktopModules = new HashSet<PortalDesktopModules>();
        }
    
        public int DesktopModuleID { get; set; }
        public string FriendlyName { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public bool IsPremium { get; set; }
        public bool IsAdmin { get; set; }
        public string BusinessControllerClass { get; set; }
        public string FolderName { get; set; }
        public string ModuleName { get; set; }
        public int SupportedFeatures { get; set; }
        public string CompatibleVersions { get; set; }
        public string Dependencies { get; set; }
        public string Permissions { get; set; }
        public int PackageID { get; set; }
        public Nullable<int> CreatedByUserID { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> LastModifiedByUserID { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
        public int ContentItemId { get; set; }
        public int Shareable { get; set; }
        public string AdminPage { get; set; }
        public string HostPage { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoreMessaging_NotificationTypes> CoreMessaging_NotificationTypes { get; set; }
        public virtual Packages Packages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModuleDefinitions> ModuleDefinitions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PortalDesktopModules> PortalDesktopModules { get; set; }
    }
}
