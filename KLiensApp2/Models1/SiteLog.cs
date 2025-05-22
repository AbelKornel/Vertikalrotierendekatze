using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("PortalId", Name = "IX_SiteLog")]
public partial class SiteLog
{
    [Key]
    public int SiteLogId { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime DateTime { get; set; }

    public int PortalId { get; set; }

    public int? UserId { get; set; }

    [StringLength(255)]
    public string? Referrer { get; set; }

    [StringLength(255)]
    public string? Url { get; set; }

    [StringLength(255)]
    public string? UserAgent { get; set; }

    [StringLength(255)]
    public string? UserHostAddress { get; set; }

    [StringLength(255)]
    public string? UserHostName { get; set; }

    public int? TabId { get; set; }

    public int? AffiliateId { get; set; }

    [ForeignKey("PortalId")]
    [InverseProperty("SiteLog")]
    public virtual Portals Portal { get; set; } = null!;
}
