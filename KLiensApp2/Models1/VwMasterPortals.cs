using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Keyless]
public partial class VwMasterPortals
{
    [Column("PortalID")]
    public int PortalId { get; set; }

    [Column("PortalGroupID")]
    public int? PortalGroupId { get; set; }

    [Column("MasterPortalID")]
    public int MasterPortalId { get; set; }
}
