using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("PortalDesktopModuleId", "PermissionId", "RoleId", "UserId", Name = "IX_DesktopModulePermission_DesktopModules", IsUnique = true)]
public partial class DesktopModulePermission
{
    [Key]
    [Column("DesktopModulePermissionID")]
    public int DesktopModulePermissionId { get; set; }

    [Column("PortalDesktopModuleID")]
    public int PortalDesktopModuleId { get; set; }

    [Column("PermissionID")]
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
    [InverseProperty("DesktopModulePermission")]
    public virtual Permission Permission { get; set; } = null!;

    [ForeignKey("PortalDesktopModuleId")]
    [InverseProperty("DesktopModulePermission")]
    public virtual PortalDesktopModules PortalDesktopModule { get; set; } = null!;

    [ForeignKey("RoleId")]
    [InverseProperty("DesktopModulePermission")]
    public virtual Roles? Role { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("DesktopModulePermission")]
    public virtual Users? User { get; set; }
}
