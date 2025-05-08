using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[PrimaryKey("FileId", "Version")]
public partial class FileVersions
{
    [Key]
    public int FileId { get; set; }

    [Key]
    public int Version { get; set; }

    [StringLength(246)]
    public string FileName { get; set; } = null!;

    [StringLength(100)]
    public string Extension { get; set; } = null!;

    public int Size { get; set; }

    public int? Width { get; set; }

    public int? Height { get; set; }

    [StringLength(200)]
    public string ContentType { get; set; } = null!;

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

    [Column("SHA1Hash")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Sha1hash { get; set; }

    [ForeignKey("FileId")]
    [InverseProperty("FileVersions")]
    public virtual Files File { get; set; } = null!;
}
