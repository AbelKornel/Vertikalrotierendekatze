using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductInventory")]
[Index("ProductBvin", Name = "IX_hcc_ProductInventory")]
public partial class HccProductInventory
{
    [Key]
    [Column("bvin")]
    [StringLength(36)]
    [Unicode(false)]
    public string Bvin { get; set; } = null!;

    public Guid ProductBvin { get; set; }

    public string VariantId { get; set; } = null!;

    public int QuantityOnHand { get; set; }

    public int QuantityReserved { get; set; }

    public int? QuantityAvailableForSale { get; set; }

    public int LowStockPoint { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public int OutOfStockPoint { get; set; }

    [ForeignKey("ProductBvin")]
    [InverseProperty("HccProductInventory")]
    public virtual HccProduct ProductBvinNavigation { get; set; } = null!;
}
