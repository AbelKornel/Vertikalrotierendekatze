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
    
    public partial class hcc_ProductXOption
    {
        public long Id { get; set; }
        public long StoreId { get; set; }
        public System.Guid ProductBvin { get; set; }
        public System.Guid OptionBvin { get; set; }
        public int SortOrder { get; set; }
    
        public virtual hcc_Product hcc_Product { get; set; }
        public virtual hcc_ProductOptions hcc_ProductOptions { get; set; }
    }
}
