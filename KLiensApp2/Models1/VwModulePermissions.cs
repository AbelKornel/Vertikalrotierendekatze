using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Keyless]
public partial class VwModulePermissions
{
    [Column("ModulePermissionID")]
    public int ModulePermissionId { get; set; }

    [Column("ModuleID")]
    public int ModuleId { get; set; }

    [Column("PortalID")]
    public int PortalId { get; set; }

    [Column("PermissionID")]
    public int PermissionId { get; set; }

    [Column("RoleID")]
    public int? RoleId { get; set; }

    [StringLength(50)]
    public string? RoleName { get; set; }

    public bool AllowAccess { get; set; }

    [Column("UserID")]
    public int? UserId { get; set; }

    [StringLength(100)]
    public string? Username { get; set; }

    [StringLength(128)]
    public string? DisplayName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PermissionCode { get; set; } = null!;

    [Column("ModuleDefID")]
    public int ModuleDefId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PermissionKey { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string PermissionName { get; set; } = null!;

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }
}
