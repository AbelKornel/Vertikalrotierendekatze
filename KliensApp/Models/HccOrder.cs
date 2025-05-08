using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_Order")]
[Index("OrderNumber", Name = "IX_hcc_Order_OrderNumber")]
[Index("StoreId", Name = "IX_hcc_Order_StoreId")]
[Index("TimeOfOrder", Name = "IX_hcc_Order_TimeOfOrder")]
[Index("UserId", Name = "IX_hcc_Order_UserId")]
public partial class HccOrder
{
    public int Id { get; set; }

    [Key]
    [Column("bvin")]
    public Guid Bvin { get; set; }

    public long? AffiliateId { get; set; }

    [Column(TypeName = "ntext")]
    public string BillingAddress { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string CustomProperties { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal FraudScore { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal GrandTotal { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal HandlingTotal { get; set; }

    public string Instructions { get; set; } = null!;

    public int IsPlaced { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal OrderDiscounts { get; set; }

    public string OrderDiscountDetails { get; set; } = null!;

    [StringLength(50)]
    public string OrderNumber { get; set; } = null!;

    public int PaymentStatus { get; set; }

    [Column(TypeName = "ntext")]
    public string ShippingAddress { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ShippingMethodId { get; set; } = null!;

    [StringLength(255)]
    public string ShippingMethodDisplayName { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ShippingProviderId { get; set; } = null!;

    [StringLength(255)]
    public string ShippingProviderServiceCode { get; set; } = null!;

    public int ShippingStatus { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal ShippingTotal { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal ShippingDiscounts { get; set; }

    public string ShippingDiscountDetails { get; set; } = null!;

    [Column(TypeName = "decimal(18, 10)")]
    public decimal SubTotal { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal TaxTotal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TimeOfOrder { get; set; }

    [StringLength(100)]
    public string UserEmail { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string UserId { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string StatusCode { get; set; } = null!;

    [StringLength(255)]
    public string StatusName { get; set; } = null!;

    [StringLength(50)]
    public string ThirdPartyOrderId { get; set; } = null!;

    public long StoreId { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal ItemsTax { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal ShippingTax { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal ShippingTaxRate { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal AdjustedShippingTotal { get; set; }

    public int UserDeviceType { get; set; }

    public bool IsAbandonedEmailSent { get; set; }

    public bool IsRecurring { get; set; }

    [StringLength(10)]
    public string UsedCulture { get; set; } = null!;

    [InverseProperty("OrderBvinNavigation")]
    public virtual ICollection<HccLineItem> HccLineItem { get; set; } = new List<HccLineItem>();

    [InverseProperty("OrderBvinNavigation")]
    public virtual ICollection<HccOrderCoupon> HccOrderCoupon { get; set; } = new List<HccOrderCoupon>();

    [InverseProperty("Order")]
    public virtual ICollection<HccOrderNote> HccOrderNote { get; set; } = new List<HccOrderNote>();

    [InverseProperty("Order")]
    public virtual ICollection<HccOrderPackage> HccOrderPackage { get; set; } = new List<HccOrderPackage>();

    [InverseProperty("Order")]
    public virtual ICollection<HccOrderTransactions> HccOrderTransactions { get; set; } = new List<HccOrderTransactions>();

    [InverseProperty("OrderBvinNavigation")]
    public virtual ICollection<HccRma> HccRma { get; set; } = new List<HccRma>();
}
