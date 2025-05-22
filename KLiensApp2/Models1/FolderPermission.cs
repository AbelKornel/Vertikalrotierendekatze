using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("FolderId", "PermissionId", "RoleId", "UserId", Name = "IX_FolderPermission_Folders", IsUnique = true)]
[Index("FolderId", Name = "IX_FolderPermission_Modules")]
[Index("PermissionId", Name = "IX_FolderPermission_Permission")]
public partial class FolderPermission
{
    [Key]
    [Column("FolderPermissionID")]
    public int FolderPermissionId { get; set; }

    [Column("FolderID")]
    public int FolderId { get; set; }

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

    [ForeignKey("FolderId")]
    [InverseProperty("FolderPermission")]
    public virtual Folders Folder { get; set; } = null!;

    [ForeignKey("PermissionId")]
    [InverseProperty("FolderPermission")]
    public virtual Permission Permission { get; set; } = null!;

    [ForeignKey("RoleId")]
    [InverseProperty("FolderPermission")]
    public virtual Roles? Role { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("FolderPermission")]
    public virtual Users? User { get; set; }
}
