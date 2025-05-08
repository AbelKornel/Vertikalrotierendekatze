using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class JavaScriptLibraries
{
    [Key]
    [Column("JavaScriptLibraryID")]
    public int JavaScriptLibraryId { get; set; }

    [Column("PackageID")]
    public int PackageId { get; set; }

    [StringLength(200)]
    public string LibraryName { get; set; } = null!;

    [StringLength(50)]
    public string Version { get; set; } = null!;

    [StringLength(100)]
    public string FileName { get; set; } = null!;

    [StringLength(100)]
    public string ObjectName { get; set; } = null!;

    public int PreferredScriptLocation { get; set; }

    [Column("CDNPath")]
    [StringLength(250)]
    public string Cdnpath { get; set; } = null!;

    [ForeignKey("PackageId")]
    [InverseProperty("JavaScriptLibraries")]
    public virtual Packages Package { get; set; } = null!;
}
