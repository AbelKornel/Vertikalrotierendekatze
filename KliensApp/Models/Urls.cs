using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("Url", "PortalId", Name = "IX_Urls", IsUnique = true)]
public partial class Urls
{
    [Key]
    [Column("UrlID")]
    public int UrlId { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [StringLength(255)]
    public string Url { get; set; } = null!;

    [ForeignKey("PortalId")]
    [InverseProperty("Urls")]
    public virtual Portals? Portal { get; set; }
}
