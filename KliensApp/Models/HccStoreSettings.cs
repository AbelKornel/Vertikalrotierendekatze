using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_StoreSettings")]
[Index("StoreId", Name = "IX_hcc_StoreSettings_StoreId")]
public partial class HccStoreSettings
{
    [Key]
    public long Id { get; set; }

    public long StoreId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SettingName { get; set; } = null!;

    public string SettingValue { get; set; } = null!;

    [InverseProperty("StoreSettings")]
    public virtual ICollection<HccStoreSettingsTranslations> HccStoreSettingsTranslations { get; set; } = new List<HccStoreSettingsTranslations>();

    [ForeignKey("StoreId")]
    [InverseProperty("HccStoreSettings")]
    public virtual HccStores Store { get; set; } = null!;
}
