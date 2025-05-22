using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("FolderId", "FileName", Name = "IX_Files_FolderId_FileName")]
[Index("PortalId", "FolderId", "FileName", Name = "IX_Files_PortalID", IsUnique = true)]
[Index("UniqueId", Name = "IX_Files_UniqueId", IsUnique = true)]
public partial class Files
{
    [Key]
    public int FileId { get; set; }

    public int? PortalId { get; set; }

    [StringLength(246)]
    public string FileName { get; set; } = null!;

    [StringLength(100)]
    public string Extension { get; set; } = null!;

    public int Size { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    [StringLength(200)]
    public string ContentType { get; set; } = null!;

    [Column("FolderID")]
    public int FolderId { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Content { get; set; }

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

    [Column("SHA1Hash")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Sha1hash { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastModificationTime { get; set; }

    [StringLength(246)]
    public string? Folder { get; set; }

    [StringLength(256)]
    public string? Title { get; set; }

    public DateOnly StartDate { get; set; }

    public bool EnablePublishPeriod { get; set; }

    public DateOnly? EndDate { get; set; }

    public int PublishedVersion { get; set; }

    [Column("ContentItemID")]
    public int? ContentItemId { get; set; }

    public bool HasBeenPublished { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [ForeignKey("ContentItemId")]
    [InverseProperty("Files")]
    public virtual ContentItems? ContentItem { get; set; }

    [InverseProperty("File")]
    public virtual ICollection<FileVersions> FileVersions { get; set; } = new List<FileVersions>();

    [ForeignKey("FolderId")]
    [InverseProperty("Files")]
    public virtual Folders FolderNavigation { get; set; } = null!;

    [ForeignKey("PortalId")]
    [InverseProperty("Files")]
    public virtual Portals? Portal { get; set; }
}
