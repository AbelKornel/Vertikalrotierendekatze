using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[PrimaryKey("ExtensionUrlProviderId", "PortalId")]
public partial class ExtensionUrlProviderConfiguration
{
    [Key]
    [Column("ExtensionUrlProviderID")]
    public int ExtensionUrlProviderId { get; set; }

    [Key]
    [Column("PortalID")]
    public int PortalId { get; set; }
}
