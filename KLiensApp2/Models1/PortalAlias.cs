using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("Httpalias", Name = "IX_PortalAlias", IsUnique = true)]
public partial class PortalAlias
{
    [Key]
    [Column("PortalAliasID")]
    public int PortalAliasId { get; set; }

    [Column("PortalID")]
    public int PortalId { get; set; }

    [Column("HTTPAlias")]
    [StringLength(200)]
    public string? Httpalias { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [StringLength(10)]
    public string? BrowserType { get; set; }

    [StringLength(100)]
    public string? Skin { get; set; }

    [StringLength(10)]
    public string? CultureCode { get; set; }

    public bool IsPrimary { get; set; }

    [ForeignKey("PortalId")]
    [InverseProperty("PortalAlias")]
    public virtual Portals Portal { get; set; } = null!;
}
