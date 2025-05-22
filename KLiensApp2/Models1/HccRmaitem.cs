using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_RMAItem")]
[Index("Rmabvin", Name = "IX_hcc_RMAItem_1")]
[Index("LineItemBvin", Name = "IX_hcc_RMAItem_LineItemBvin")]
public partial class HccRmaitem
{
    [Key]
    [Column("bvin")]
    public Guid Bvin { get; set; }

    [Column("RMABvin")]
    public Guid Rmabvin { get; set; }

    public long LineItemBvin { get; set; }

    [StringLength(512)]
    public string ItemName { get; set; } = null!;

    public string ItemDescription { get; set; } = null!;

    public string Note { get; set; } = null!;

    public string Reason { get; set; } = null!;

    public bool Replace { get; set; }

    public int Quantity { get; set; }

    public int QuantityReceived { get; set; }

    public int QuantityReturnedToInventory { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal RefundAmount { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal RefundShippingAmount { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal RefundTaxAmount { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal RefundGiftWrapAmount { get; set; }

    [StringLength(50)]
    public string ProductClass { get; set; } = null!;

    [ForeignKey("Rmabvin")]
    [InverseProperty("HccRmaitem")]
    public virtual HccRma RmabvinNavigation { get; set; } = null!;
}
