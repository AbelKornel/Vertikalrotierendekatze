using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class ExtensionUrlProviders
{
    [Key]
    [Column("ExtensionUrlProviderID")]
    public int ExtensionUrlProviderId { get; set; }

    [StringLength(150)]
    public string ProviderName { get; set; } = null!;

    [StringLength(1000)]
    public string ProviderType { get; set; } = null!;

    [StringLength(1000)]
    public string? SettingsControlSrc { get; set; }

    public bool IsActive { get; set; }

    public bool RewriteAllUrls { get; set; }

    public bool RedirectAllUrls { get; set; }

    public bool ReplaceAllUrls { get; set; }

    public int? DesktopModuleId { get; set; }
}
