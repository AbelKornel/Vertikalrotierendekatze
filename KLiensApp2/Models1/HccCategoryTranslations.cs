using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_CategoryTranslations")]
[Index("CategoryId", "Culture", Name = "UK_hcc_CategoryTranslations", IsUnique = true)]
public partial class HccCategoryTranslations
{
    [Key]
    public long CategoryTranslationId { get; set; }

    public Guid CategoryId { get; set; }

    [StringLength(10)]
    public string Culture { get; set; } = null!;

    [StringLength(255)]
    public string Name { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string? Description { get; set; }

    [StringLength(512)]
    public string? MetaTitle { get; set; }

    [StringLength(255)]
    public string? MetaKeywords { get; set; }

    [StringLength(255)]
    public string? MetaDescription { get; set; }

    public string? Keywords { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("HccCategoryTranslations")]
    public virtual HccCategory Category { get; set; } = null!;
}
