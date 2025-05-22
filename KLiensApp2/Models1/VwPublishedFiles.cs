using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Keyless]
public partial class VwPublishedFiles
{
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

    [StringLength(256)]
    public string? Title { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    public DateOnly StartDate { get; set; }

    public bool EnablePublishPeriod { get; set; }

    public DateOnly? EndDate { get; set; }

    [Column("ContentItemID")]
    public int? ContentItemId { get; set; }

    public int PublishedVersion { get; set; }

    [StringLength(300)]
    public string Folder { get; set; } = null!;

    public bool IsCached { get; set; }

    public int StorageLocation { get; set; }

    [Column("FolderMappingID")]
    public int FolderMappingId { get; set; }

    public bool HasBeenPublished { get; set; }
}
