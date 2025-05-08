using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class PackageTypes
{
    [Key]
    [StringLength(100)]
    public string PackageType { get; set; } = null!;

    [StringLength(500)]
    public string Description { get; set; } = null!;

    public int SecurityAccessLevel { get; set; }

    [StringLength(250)]
    public string? EditorControlSrc { get; set; }

    public bool SupportsSideBySideInstallation { get; set; }

    [InverseProperty("PackageTypeNavigation")]
    public virtual ICollection<Packages> Packages { get; set; } = new List<Packages>();
}
