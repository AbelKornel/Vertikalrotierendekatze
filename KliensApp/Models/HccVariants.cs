using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_Variants")]
[Index("Bvin", "ProductId", "StoreId", Name = "IX_hcc_Variants_BvinProductStore")]
public partial class HccVariants
{
    [Key]
    [Column("bvin")]
    public Guid Bvin { get; set; }

    public Guid ProductId { get; set; }

    [StringLength(255)]
    public string Sku { get; set; } = null!;

    [Column(TypeName = "decimal(18, 10)")]
    public decimal Price { get; set; }

    public string SelectionData { get; set; } = null!;

    public long StoreId { get; set; }

    public string CustomProperty { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("HccVariants")]
    public virtual HccProduct Product { get; set; } = null!;
}
