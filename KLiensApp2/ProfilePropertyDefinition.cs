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
    
    public partial class ProfilePropertyDefinition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProfilePropertyDefinition()
        {
            this.UserProfile = new HashSet<UserProfile>();
        }
    
        public int PropertyDefinitionID { get; set; }
        public Nullable<int> PortalID { get; set; }
        public Nullable<int> ModuleDefID { get; set; }
        public bool Deleted { get; set; }
        public int DataType { get; set; }
        public string DefaultValue { get; set; }
        public string PropertyCategory { get; set; }
        public string PropertyName { get; set; }
        public int Length { get; set; }
        public bool Required { get; set; }
        public string ValidationExpression { get; set; }
        public int ViewOrder { get; set; }
        public bool Visible { get; set; }
        public Nullable<int> CreatedByUserID { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> LastModifiedByUserID { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
        public Nullable<int> DefaultVisibility { get; set; }
        public bool ReadOnly { get; set; }
    
        public virtual Portals Portals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserProfile> UserProfile { get; set; }
    }
}
