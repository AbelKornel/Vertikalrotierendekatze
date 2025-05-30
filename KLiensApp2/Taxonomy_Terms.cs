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
    
    public partial class Taxonomy_Terms
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Taxonomy_Terms()
        {
            this.ContentItems_Tags = new HashSet<ContentItems_Tags>();
            this.Taxonomy_Terms1 = new HashSet<Taxonomy_Terms>();
        }
    
        public int TermID { get; set; }
        public int VocabularyID { get; set; }
        public Nullable<int> ParentTermID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public int TermLeft { get; set; }
        public int TermRight { get; set; }
        public Nullable<int> CreatedByUserID { get; set; }
        public Nullable<System.DateTime> CreatedOnDate { get; set; }
        public Nullable<int> LastModifiedByUserID { get; set; }
        public Nullable<System.DateTime> LastModifiedOnDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContentItems_Tags> ContentItems_Tags { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Taxonomy_Terms> Taxonomy_Terms1 { get; set; }
        public virtual Taxonomy_Terms Taxonomy_Terms2 { get; set; }
        public virtual Taxonomy_Vocabularies Taxonomy_Vocabularies { get; set; }
    }
}
