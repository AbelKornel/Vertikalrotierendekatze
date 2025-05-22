using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class PackageDependencies
{
    [Key]
    [Column("PackageDependencyID")]
    public int PackageDependencyId { get; set; }

    [Column("PackageID")]
    public int PackageId { get; set; }

    [StringLength(128)]
    public string PackageName { get; set; } = null!;

    [StringLength(50)]
    public string Version { get; set; } = null!;

    [ForeignKey("PackageId")]
    [InverseProperty("PackageDependencies")]
    public virtual Packages Package { get; set; } = null!;
}
