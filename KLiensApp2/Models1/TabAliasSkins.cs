using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class TabAliasSkins
{
    [Key]
    public int TabAliasSkinId { get; set; }

    public int TabId { get; set; }

    public int PortalAliasId { get; set; }

    [StringLength(200)]
    public string SkinSrc { get; set; } = null!;

    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }
}
