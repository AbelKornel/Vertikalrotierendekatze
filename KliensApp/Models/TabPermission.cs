using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("PermissionId", Name = "IX_TabPermission_Permission")]
[Index("TabId", "PermissionId", "RoleId", "UserId", Name = "IX_TabPermission_Tabs", IsUnique = true)]
public partial class TabPermission
{
    [Key]
    [Column("TabPermissionID")]
    public int TabPermissionId { get; set; }

    [Column("TabID")]
    public int TabId { get; set; }

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
    [InverseProperty("TabPermission")]
    public virtual Permission Permission { get; set; } = null!;

    [ForeignKey("RoleId")]
    [InverseProperty("TabPermission")]
    public virtual Roles? Role { get; set; }

    [ForeignKey("TabId")]
    [InverseProperty("TabPermission")]
    public virtual Tabs Tab { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("TabPermission")]
    public virtual Users? User { get; set; }
}
