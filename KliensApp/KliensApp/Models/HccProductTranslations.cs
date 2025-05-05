using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductTranslations")]
[Index("ProductId", "Culture", Name = "UK_hcc_ProductTranslations", IsUnique = true)]
public partial class HccProductTranslations
{
    [Key]
    public long ProductTranslationId { get; set; }

    public Guid ProductId { get; set; }

    [StringLength(10)]
    public string Culture { get; set; } = null!;

    [StringLength(255)]
    public string ProductName { get; set; } = null!;

    [StringLength(255)]
    public string? MetaKeywords { get; set; }

    [StringLength(255)]
    public string? MetaDescription { get; set; }

    [StringLength(512)]
    public string? MetaTitle { get; set; }

    [StringLength(512)]
    public string? ShortDescription { get; set; }

    public string? LongDescription { get; set; }

    public string? Keywords { get; set; }

    [StringLength(255)]
    public string? SitePriceOverrideText { get; set; }

    [StringLength(255)]
    public string? SmallImageAlternateText { get; set; }

    [StringLength(255)]
    public string? MediumImageAlternateText { get; set; }

    [Column(TypeName = "ntext")]
    public string? DescriptionTabs { get; set; }

    public string? HiddenSearchKeywords { get; set; }

    [StringLength(4000)]
    public string? UserPriceLabel { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("HccProductTranslations")]
    public virtual HccProduct Product { get; set; } = null!;
}
