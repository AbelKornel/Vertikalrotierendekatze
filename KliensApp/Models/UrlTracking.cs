using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("PortalId", "Url", "ModuleId", Name = "IX_UrlTracking", IsUnique = true)]
[Index("ModuleId", Name = "IX_UrlTracking_ModuleId")]
[Index("Url", "ModuleId", Name = "IX_UrlTracking_Url_ModuleId")]
public partial class UrlTracking
{
    [Key]
    [Column("UrlTrackingID")]
    public int UrlTrackingId { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [StringLength(255)]
    public string Url { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string UrlType { get; set; } = null!;

    public int Clicks { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastClick { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    public bool LogActivity { get; set; }

    public bool TrackClicks { get; set; }

    public int? ModuleId { get; set; }

    public bool NewWindow { get; set; }

    [ForeignKey("PortalId")]
    [InverseProperty("UrlTracking")]
    public virtual Portals? Portal { get; set; }

    [InverseProperty("UrlTracking")]
    public virtual ICollection<UrlLog> UrlLog { get; set; } = new List<UrlLog>();
}
