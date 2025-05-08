using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductImage")]
[Index("ProductId", Name = "IX_hcc_ProductImage")]
public partial class HccProductImage
{
    [Key]
    [Column("bvin")]
    public Guid Bvin { get; set; }

    [Column("ProductID")]
    public Guid ProductId { get; set; }

    public string FileName { get; set; } = null!;

    public string Caption { get; set; } = null!;

    public string AlternateText { get; set; } = null!;

    public int SortOrder { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("HccProductImage")]
    public virtual HccProduct Product { get; set; } = null!;
}
