using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("PermissionId", Name = "IX_PortalPermission_Permission")]
[Index("PortalId", "PermissionId", "RoleId", "UserId", Name = "IX_PortalPermission_Portals", IsUnique = true)]
public partial class PortalPermission
{
    [Key]
    public int PortalPermissionId { get; set; }

    public int? PortalId { get; set; }

    public int PermissionId { get; set; }

    public bool AllowAccess { get; set; }

    [Column("RoleID")]
    public int? RoleId { get; set; }

    [Column("UserID")]
    public int? UserId { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [ForeignKey("PermissionId")]
    [InverseProperty("PortalPermission")]
    public virtual Permission Permission { get; set; } = null!;

    [ForeignKey("PortalId")]
    [InverseProperty("PortalPermission")]
    public virtual Portals? Portal { get; set; }

    [ForeignKey("RoleId")]
    [InverseProperty("PortalPermission")]
    public virtual Roles? Role { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("PortalPermission")]
    public virtual Users? User { get; set; }
}
