using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_StoreSettingsTranslations")]
[Index("StoreSettingsId", "Culture", Name = "UK_hcc_StoreSettingsTranslations", IsUnique = true)]
public partial class HccStoreSettingsTranslations
{
    [Key]
    public long StoreSettingsTranslationId { get; set; }

    public long StoreSettingsId { get; set; }

    [StringLength(10)]
    public string Culture { get; set; } = null!;

    public string? LocalizedSettingValue { get; set; }

    [ForeignKey("StoreSettingsId")]
    [InverseProperty("HccStoreSettingsTranslations")]
    public virtual HccStoreSettings StoreSettings { get; set; } = null!;
}
