using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[PrimaryKey("ExtensionUrlProviderId", "PortalId", "TabId")]
public partial class ExtensionUrlProviderTab
{
    [Key]
    [Column("ExtensionUrlProviderID")]
    public int ExtensionUrlProviderId { get; set; }

    [Key]
    [Column("PortalID")]
    public int PortalId { get; set; }

    [Key]
    [Column("TabID")]
    public int TabId { get; set; }

    public bool IsActive { get; set; }
}
