using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_LineItem")]
[Index("OrderBvin", Name = "IX_hcc_LineItem_1")]
public partial class HccLineItem
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public Guid ProductId { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string VariantId { get; set; } = null!;

    public int Quantity { get; set; }

    public Guid OrderBvin { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal BasePrice { get; set; }

    public string DiscountDetails { get; set; } = null!;

    [Column(TypeName = "decimal(18, 10)")]
    public decimal AdjustedPrice { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal ShippingPortion { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal TaxPortion { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal LineTotal { get; set; }

    [Column(TypeName = "ntext")]
    public string CustomProperties { get; set; } = null!;

    public int QuantityReturned { get; set; }

    public int QuantityShipped { get; set; }

    [StringLength(255)]
    public string ProductName { get; set; } = null!;

    public string ProductShortDescription { get; set; } = null!;

    [StringLength(50)]
    public string ProductSku { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string StatusCode { get; set; } = null!;

    [StringLength(255)]
    public string StatusName { get; set; } = null!;

    public string SelectionData { get; set; } = null!;

    public long StoreId { get; set; }

    public int IsNonShipping { get; set; }

    public long TaxScheduleId { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal ProductShippingWeight { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal ProductShippingLength { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal ProductShippingWidth { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal ProductShippingHeight { get; set; }

    public string ShipFromAddress { get; set; } = null!;

    public int ShipFromMode { get; set; }

    [StringLength(50)]
    public string ShipFromNotificationId { get; set; } = null!;

    public bool ShipSeparately { get; set; }

    [Column(TypeName = "numeric(10, 4)")]
    public decimal ExtraShipCharge { get; set; }

    public bool IsUserSuppliedPrice { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal TaxRate { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal ShippingTaxRate { get; set; }

    public bool IsBundle { get; set; }

    public int QuantityReserved { get; set; }

    public bool IsGiftCard { get; set; }

    public bool IsRecurring { get; set; }

    public int? RecurringInterval { get; set; }

    public int? RecurringIntervalType { get; set; }

    public bool IsRecurringCancelled { get; set; }

    public int ShippingCharge { get; set; }

    public int FreeQuantity { get; set; }

    [StringLength(500)]
    public string? PromotionIds { get; set; }

    public bool IsUpchargeAllowed { get; set; }

    [ForeignKey("OrderBvin")]
    [InverseProperty("HccLineItem")]
    public virtual HccOrder OrderBvinNavigation { get; set; } = null!;
}
