using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductPropertyValueTranslations")]
[Index("ProductPropertyValueId", "Culture", Name = "IX_hcc_ProductPropertyValueTranslations", IsUnique = true)]
public partial class HccProductPropertyValueTranslations
{
    [Key]
    public long ProductPropertyValueTranslationId { get; set; }

    public long ProductPropertyValueId { get; set; }

    [StringLength(10)]
    public string Culture { get; set; } = null!;

    public string? PropertyLocalizableValue { get; set; }

    [ForeignKey("ProductPropertyValueId")]
    [InverseProperty("HccProductPropertyValueTranslations")]
    public virtual HccProductPropertyValue ProductPropertyValue { get; set; } = null!;
}
