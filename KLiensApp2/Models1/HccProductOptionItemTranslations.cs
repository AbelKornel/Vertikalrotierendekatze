using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductOptionItemTranslations")]
[Index("ProductOptionItemId", "Culture", Name = "UK_hcc_ProductOptionItemTranslations", IsUnique = true)]
public partial class HccProductOptionItemTranslations
{
    [Key]
    public long ProductOptionItemTranslationId { get; set; }

    public Guid ProductOptionItemId { get; set; }

    [StringLength(10)]
    public string Culture { get; set; } = null!;

    [StringLength(255)]
    public string? Name { get; set; }

    [ForeignKey("ProductOptionItemId")]
    [InverseProperty("HccProductOptionItemTranslations")]
    public virtual HccProductOptionsItems ProductOptionItem { get; set; } = null!;
}
