using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductPropertyChoiceTranslations")]
[Index("ProductPropertyChoiceId", "Culture", Name = "IX_hcc_ProductPropertyChoiceTranslations", IsUnique = true)]
public partial class HccProductPropertyChoiceTranslations
{
    [Key]
    public long ProductPropertyChoiceTranslationId { get; set; }

    public long ProductPropertyChoiceId { get; set; }

    [StringLength(10)]
    public string Culture { get; set; } = null!;

    [StringLength(512)]
    public string? DisplayName { get; set; }

    [ForeignKey("ProductPropertyChoiceId")]
    [InverseProperty("HccProductPropertyChoiceTranslations")]
    public virtual HccProductPropertyChoice ProductPropertyChoice { get; set; } = null!;
}
