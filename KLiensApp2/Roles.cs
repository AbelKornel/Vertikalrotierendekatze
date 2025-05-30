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
    
    public partial class Roles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Roles()
        {
            this.DesktopModulePermission = new HashSet<DesktopModulePermission>();
            this.FolderPermission = new HashSet<FolderPermission>();
            this.ModulePermission = new HashSet<ModulePermission>();
            this.PersonaBarMenuPermission = new HashSet<PersonaBarMenuPermission>();
            this.PortalPermission = new HashSet<PortalPermission>();
            this.TabPermission = new HashSet<TabPermission>();
            this.UserRoles = new HashSet<UserRoles>();
        }
    
        public int RoleID { get; set; }
        public Nullable<int> PortalID { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> ServiceFee { get; set; }
        public string BillingFrequency { get; set; }
        public Nullable<int> TrialPeriod { get; set; }
        public string TrialFrequency { get; set; }
        public Nullable<int> BillingPeriod { get; set; }
        public Nullable<decimal> TrialFee { get; set; }
        public bool IsPublic { get; set; }
        public bool AutoAssignment { get; set; }
        public Nullable<int> RoleGroupID { get; set; }
        public string RSVPCode { get; set; }
        public string IconFile { get; set; }
        public Nullable<int> CreatedByUserID { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> LastModifiedByUserID { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
        public int Status { get; set; }
        public int SecurityMode { get; set; }
        public bool IsSystemRole { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DesktopModulePermission> DesktopModulePermission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FolderPermission> FolderPermission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ModulePermission> ModulePermission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonaBarMenuPermission> PersonaBarMenuPermission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PortalPermission> PortalPermission { get; set; }
        public virtual Portals Portals { get; set; }
        public virtual RoleGroups RoleGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TabPermission> TabPermission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
