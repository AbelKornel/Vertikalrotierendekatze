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
    
    public partial class hcc_ContentBlock
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hcc_ContentBlock()
        {
            this.hcc_ContentBlockTranslations = new HashSet<hcc_ContentBlockTranslations>();
        }
    
        public System.Guid bvin { get; set; }
        public System.Guid ColumnID { get; set; }
        public int SortOrder { get; set; }
        public string ControlName { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public long StoreId { get; set; }
        public string SerializedSettings { get; set; }
        public string SerializedLists { get; set; }
    
        public virtual hcc_ContentColumn hcc_ContentColumn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hcc_ContentBlockTranslations> hcc_ContentBlockTranslations { get; set; }
    }
}
