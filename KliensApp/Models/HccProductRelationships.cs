using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductRelationships")]
[Index("ProductId", Name = "IX_hcc_ProductRelationships_ProductId")]
[Index("RelatedProductId", Name = "IX_hcc_ProductRelationships_RelatedProductId")]
public partial class HccProductRelationships
{
    [Key]
    public long Id { get; set; }

    public Guid ProductId { get; set; }

    public Guid RelatedProductId { get; set; }

    public bool IsSubstitute { get; set; }

    public int SortOrder { get; set; }

    public string MarketingDescription { get; set; } = null!;

    public long StoreId { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("HccProductRelationships")]
    public virtual HccProduct Product { get; set; } = null!;
}
