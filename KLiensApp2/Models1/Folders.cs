using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("PortalId", "FolderPath", Name = "IX_FolderPath", IsUnique = true)]
[Index("FolderId", Name = "IX_Folders_FolderID", IsUnique = true)]
[Index("PortalId", "ParentId", "FolderPath", Name = "IX_Folders_ParentID")]
[Index("UniqueId", Name = "IX_Folders_UniqueId", IsUnique = true)]
public partial class Folders
{
    [Key]
    [Column("FolderID")]
    public int FolderId { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [StringLength(300)]
    public string FolderPath { get; set; } = null!;

    public int StorageLocation { get; set; }

    public bool IsProtected { get; set; }

    public bool IsCached { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastUpdated { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    public Guid UniqueId { get; set; }

    public Guid VersionGuid { get; set; }

    [Column("FolderMappingID")]
    public int FolderMappingId { get; set; }

    [Column("ParentID")]
    public int? ParentId { get; set; }

    public bool IsVersioned { get; set; }

    [Column("WorkflowID")]
    public int? WorkflowId { get; set; }

    [StringLength(300)]
    public string? MappedPath { get; set; }

    [InverseProperty("FolderNavigation")]
    public virtual ICollection<Files> Files { get; set; } = new List<Files>();

    [ForeignKey("FolderMappingId")]
    [InverseProperty("Folders")]
    public virtual FolderMappings FolderMapping { get; set; } = null!;

    [InverseProperty("Folder")]
    public virtual ICollection<FolderPermission> FolderPermission { get; set; } = new List<FolderPermission>();

    [ForeignKey("PortalId")]
    [InverseProperty("Folders")]
    public virtual Portals? Portal { get; set; }

    [ForeignKey("WorkflowId")]
    [InverseProperty("Folders")]
    public virtual ContentWorkflows? Workflow { get; set; }
}
