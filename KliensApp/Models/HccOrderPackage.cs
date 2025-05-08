using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_OrderPackage")]
[Index("OrderId", Name = "IX_hcc_OrderPackage_OrderId")]
public partial class HccOrderPackage
{
    [Key]
    public long Id { get; set; }

    public string Description { get; set; } = null!;

    [Column(TypeName = "decimal(18, 4)")]
    public decimal Width { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal Height { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal Length { get; set; }

    public int SizeUnits { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal Weight { get; set; }

    public int WeightUnits { get; set; }

    public Guid OrderId { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string ShippingProviderId { get; set; } = null!;

    [StringLength(255)]
    public string ShippingProviderServiceCode { get; set; } = null!;

    public int HasShipped { get; set; }

    [StringLength(255)]
    public string TrackingNumber { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ShipDateUtc { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal EstimatedShippingCost { get; set; }

    public string Items { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedUtc { get; set; }

    [Column(TypeName = "ntext")]
    public string CustomProperties { get; set; } = null!;

    public long StoreId { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string? ShippingMethodId { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("HccOrderPackage")]
    public virtual HccOrder Order { get; set; } = null!;
}
