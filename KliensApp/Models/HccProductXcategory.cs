using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductXCategory")]
[Index("ProductId", "CategoryId", Name = "IX_hcc_ProductXCategory_1", IsUnique = true)]
[Index("CategoryId", Name = "IX_hcc_ProductXCategory_2")]
public partial class HccProductXcategory
{
    [Key]
    public long Id { get; set; }

    public Guid ProductId { get; set; }

    public Guid CategoryId { get; set; }

    public int SortOrder { get; set; }

    public long StoreId { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("HccProductXcategory")]
    public virtual HccCategory Category { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("HccProductXcategory")]
    public virtual HccProduct Product { get; set; } = null!;
}
