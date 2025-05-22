using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[PrimaryKey("ExtensionUrlProviderId", "PortalId", "SettingName")]
public partial class ExtensionUrlProviderSetting
{
    [Key]
    [Column("ExtensionUrlProviderID")]
    public int ExtensionUrlProviderId { get; set; }

    [Key]
    [Column("PortalID")]
    public int PortalId { get; set; }

    [Key]
    [StringLength(100)]
    public string SettingName { get; set; } = null!;

    [StringLength(2000)]
    public string SettingValue { get; set; } = null!;
}
