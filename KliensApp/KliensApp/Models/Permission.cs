using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("PermissionCode", "ModuleDefId", "PermissionKey", Name = "IX_Permission", IsUnique = true)]
public partial class Permission
{
    [Key]
    [Column("PermissionID")]
    public int PermissionId { get; set; }

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

    public int ViewOrder { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [InverseProperty("Permission")]
    public virtual ICollection<ContentWorkflowStatePermission> ContentWorkflowStatePermission { get; set; } = new List<ContentWorkflowStatePermission>();

    [InverseProperty("Permission")]
    public virtual ICollection<DesktopModulePermission> DesktopModulePermission { get; set; } = new List<DesktopModulePermission>();

    [InverseProperty("Permission")]
    public virtual ICollection<FolderPermission> FolderPermission { get; set; } = new List<FolderPermission>();

    [InverseProperty("Permission")]
    public virtual ICollection<ModulePermission> ModulePermission { get; set; } = new List<ModulePermission>();

    [InverseProperty("Permission")]
    public virtual ICollection<PortalPermission> PortalPermission { get; set; } = new List<PortalPermission>();

    [InverseProperty("Permission")]
    public virtual ICollection<TabPermission> TabPermission { get; set; } = new List<TabPermission>();
}
