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
    
    public partial class hcc_ProductFileXProduct
    {
        public System.Guid ProductFileId { get; set; }
        public System.Guid ProductId { get; set; }
        public int AvailableMinutes { get; set; }
        public int MaxDownloads { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public long StoreId { get; set; }
        public long Id { get; set; }
    
        public virtual hcc_Product hcc_Product { get; set; }
        public virtual hcc_ProductFile hcc_ProductFile { get; set; }
    }
}
