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
    
    public partial class hcc_ProductOptionsItems
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hcc_ProductOptionsItems()
        {
            this.hcc_ProductOptionItemTranslations = new HashSet<hcc_ProductOptionItemTranslations>();
        }
    
        public System.Guid bvin { get; set; }
        public long StoreId { get; set; }
        public System.Guid OptionBvin { get; set; }
        public decimal PriceAdjustment { get; set; }
        public decimal WeightAdjustment { get; set; }
        public bool IsLabel { get; set; }
        public int SortOrder { get; set; }
        public bool IsDefault { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hcc_ProductOptionItemTranslations> hcc_ProductOptionItemTranslations { get; set; }
        public virtual hcc_ProductOptions hcc_ProductOptions { get; set; }
    }
}
