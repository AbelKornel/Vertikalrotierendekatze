using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_PromotionTranslations")]
[Index("PromotionId", "Culture", Name = "UK_hcc_PromotionTranslations", IsUnique = true)]
public partial class HccPromotionTranslations
{
    [Key]
    public long PromotionTranslationId { get; set; }

    public long PromotionId { get; set; }

    [StringLength(10)]
    public string Culture { get; set; } = null!;

    [StringLength(255)]
    public string? CustomerDescription { get; set; }

    [ForeignKey("PromotionId")]
    [InverseProperty("HccPromotionTranslations")]
    public virtual HccPromotions Promotion { get; set; } = null!;
}
