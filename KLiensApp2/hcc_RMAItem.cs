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
    
    public partial class hcc_RMAItem
    {
        public System.Guid bvin { get; set; }
        public System.Guid RMABvin { get; set; }
        public long LineItemBvin { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string Note { get; set; }
        public string Reason { get; set; }
        public bool Replace { get; set; }
        public int Quantity { get; set; }
        public int QuantityReceived { get; set; }
        public int QuantityReturnedToInventory { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public long StoreId { get; set; }
        public decimal RefundAmount { get; set; }
        public decimal RefundShippingAmount { get; set; }
        public decimal RefundTaxAmount { get; set; }
        public decimal RefundGiftWrapAmount { get; set; }
        public string ProductClass { get; set; }
    
        public virtual hcc_RMA hcc_RMA { get; set; }
    }
}
