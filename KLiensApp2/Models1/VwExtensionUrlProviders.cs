using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Keyless]
public partial class VwExtensionUrlProviders
{
    [Column("ExtensionUrlProviderID")]
    public int ExtensionUrlProviderId { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [StringLength(150)]
    public string ProviderName { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool RewriteAllUrls { get; set; }

    public bool RedirectAllUrls { get; set; }

    public bool ReplaceAllUrls { get; set; }

    public int? DesktopModuleId { get; set; }
}
