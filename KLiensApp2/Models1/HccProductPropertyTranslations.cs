using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductPropertyTranslations")]
[Index("ProductPropertyId", "Culture", Name = "UK_hcc_ProductPropertyTranslations", IsUnique = true)]
public partial class HccProductPropertyTranslations
{
    [Key]
    public long ProductPropertyTranslationId { get; set; }

    public long ProductPropertyId { get; set; }

    [StringLength(10)]
    public string Culture { get; set; } = null!;

    [StringLength(512)]
    public string? DisplayName { get; set; }

    public string? DefaultLocalizableValue { get; set; }

    [ForeignKey("ProductPropertyId")]
    [InverseProperty("HccProductPropertyTranslations")]
    public virtual HccProductProperty ProductProperty { get; set; } = null!;
}
