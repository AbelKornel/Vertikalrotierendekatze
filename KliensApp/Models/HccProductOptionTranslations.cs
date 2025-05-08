using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductOptionTranslations")]
[Index("ProductOptionId", "Culture", Name = "UK_hcc_ProductOptionTranslations", IsUnique = true)]
public partial class HccProductOptionTranslations
{
    [Key]
    public long ProductOptionTranslationId { get; set; }

    public Guid ProductOptionId { get; set; }

    [StringLength(10)]
    public string Culture { get; set; } = null!;

    [StringLength(255)]
    public string? Name { get; set; }

    public string? TextSettings { get; set; }

    [ForeignKey("ProductOptionId")]
    [InverseProperty("HccProductOptionTranslations")]
    public virtual HccProductOptions ProductOption { get; set; } = null!;
}
