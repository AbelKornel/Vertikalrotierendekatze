using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("ModuleId", "PermissionId", "PortalId", "RoleId", "UserId", Name = "IX_ModulePermission_Modules", IsUnique = true)]
[Index("PermissionId", Name = "IX_ModulePermission_Permission")]
[Index("PortalId", Name = "IX_ModulePermission_Portal")]
public partial class ModulePermission
{
    [Key]
    [Column("ModulePermissionID")]
    public int ModulePermissionId { get; set; }

    [Column("ModuleID")]
    public int ModuleId { get; set; }

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

    [Column("PortalID")]
    public int PortalId { get; set; }

    [ForeignKey("ModuleId")]
    [InverseProperty("ModulePermission")]
    public virtual Modules Module { get; set; } = null!;

    [ForeignKey("PermissionId")]
    [InverseProperty("ModulePermission")]
    public virtual Permission Permission { get; set; } = null!;

    [ForeignKey("RoleId")]
    [InverseProperty("ModulePermission")]
    public virtual Roles? Role { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("ModulePermission")]
    public virtual Users? User { get; set; }
}
