using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_Promotions")]
[Index("IsEnabled", Name = "IX_hcc_Promotions_IsEnabled")]
[Index("Mode", Name = "IX_hcc_Promotions_Mode")]
[Index("StoreId", Name = "IX_hcc_Promotions_StoreId")]
public partial class HccPromotions
{
    [Key]
    public long Id { get; set; }

    public long StoreId { get; set; }

    public int Mode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedUtc { get; set; }

    [StringLength(255)]
    public string Name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StartDateUtc { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndDateUtc { get; set; }

    public bool IsEnabled { get; set; }

    public string QualificationsXml { get; set; } = null!;

    public string ActionsXml { get; set; } = null!;

    public bool DoNotCombine { get; set; }

    public int SortOrder { get; set; }

    [InverseProperty("Promotion")]
    public virtual ICollection<HccPromotionTranslations> HccPromotionTranslations { get; set; } = new List<HccPromotionTranslations>();
}
