using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class Assemblies
{
    [Key]
    [Column("AssemblyID")]
    public int AssemblyId { get; set; }

    [Column("PackageID")]
    public int? PackageId { get; set; }

    [StringLength(250)]
    public string AssemblyName { get; set; } = null!;

    [StringLength(20)]
    public string Version { get; set; } = null!;

    [ForeignKey("PackageId")]
    [InverseProperty("Assemblies")]
    public virtual Packages? Package { get; set; }
}
