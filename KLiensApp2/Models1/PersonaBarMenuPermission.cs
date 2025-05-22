using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("PortalId", "MenuId", "PermissionId", "UserId", "RoleId", Name = "IX_PersonaBarMenuPermission", IsUnique = true)]
public partial class PersonaBarMenuPermission
{
    [Key]
    public int MenuPermissionId { get; set; }

    public int? PortalId { get; set; }

    public int MenuId { get; set; }

    public int PermissionId { get; set; }

    public bool AllowAccess { get; set; }

    public int? RoleId { get; set; }

    public int? UserId { get; set; }

    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [ForeignKey("MenuId")]
    [InverseProperty("PersonaBarMenuPermission")]
    public virtual PersonaBarMenu Menu { get; set; } = null!;

    [ForeignKey("PermissionId")]
    [InverseProperty("PersonaBarMenuPermission")]
    public virtual PersonaBarPermission Permission { get; set; } = null!;

    [ForeignKey("PortalId")]
    [InverseProperty("PersonaBarMenuPermission")]
    public virtual Portals? Portal { get; set; }

    [ForeignKey("RoleId")]
    [InverseProperty("PersonaBarMenuPermission")]
    public virtual Roles? Role { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("PersonaBarMenuPermission")]
    public virtual Users? User { get; set; }
}
