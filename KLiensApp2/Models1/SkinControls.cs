using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class SkinControls
{
    [Key]
    [Column("SkinControlID")]
    public int SkinControlId { get; set; }

    [Column("PackageID")]
    public int PackageId { get; set; }

    [StringLength(50)]
    public string? ControlKey { get; set; }

    [StringLength(256)]
    public string? ControlSrc { get; set; }

    [StringLength(100)]
    public string? IconFile { get; set; }

    [StringLength(200)]
    public string? HelpUrl { get; set; }

    public bool SupportsPartialRendering { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [ForeignKey("PackageId")]
    [InverseProperty("SkinControls")]
    public virtual Packages Package { get; set; } = null!;
}
