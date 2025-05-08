using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductVolumeDiscounts")]
[Index("ProductId", Name = "IX_hcc_ProductVolumeDiscounts")]
public partial class HccProductVolumeDiscounts
{
    [Key]
    [Column("bvin")]
    public Guid Bvin { get; set; }

    [Column("ProductID")]
    public Guid ProductId { get; set; }

    public int Qty { get; set; }

    public int DiscountType { get; set; }

    [Column(TypeName = "numeric(18, 10)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("HccProductVolumeDiscounts")]
    public virtual HccProduct Product { get; set; } = null!;
}
