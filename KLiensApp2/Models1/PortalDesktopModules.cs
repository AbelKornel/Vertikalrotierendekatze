using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("PortalId", "DesktopModuleId", Name = "IX_PortalDesktopModules", IsUnique = true)]
public partial class PortalDesktopModules
{
    [Key]
    [Column("PortalDesktopModuleID")]
    public int PortalDesktopModuleId { get; set; }

    [Column("PortalID")]
    public int PortalId { get; set; }

    [Column("DesktopModuleID")]
    public int DesktopModuleId { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [ForeignKey("DesktopModuleId")]
    [InverseProperty("PortalDesktopModules")]
    public virtual DesktopModules DesktopModule { get; set; } = null!;

    [InverseProperty("PortalDesktopModule")]
    public virtual ICollection<DesktopModulePermission> DesktopModulePermission { get; set; } = new List<DesktopModulePermission>();

    [ForeignKey("PortalId")]
    [InverseProperty("PortalDesktopModules")]
    public virtual Portals Portal { get; set; } = null!;
}
