using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Keyless]
public partial class VwProfile
{
    [Column("UserID")]
    public int UserId { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [StringLength(50)]
    public string PropertyName { get; set; } = null!;

    public string? PropertyValue { get; set; }

    public int Visibility { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? ExtendedVisibility { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDate { get; set; }

    [Column("PropertyDefinitionID")]
    public int PropertyDefinitionId { get; set; }
}
