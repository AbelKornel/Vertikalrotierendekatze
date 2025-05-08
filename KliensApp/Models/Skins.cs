using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class Skins
{
    [Key]
    [Column("SkinID")]
    public int SkinId { get; set; }

    [Column("SkinPackageID")]
    public int SkinPackageId { get; set; }

    [StringLength(250)]
    public string SkinSrc { get; set; } = null!;

    [ForeignKey("SkinPackageId")]
    [InverseProperty("Skins")]
    public virtual SkinPackages SkinPackage { get; set; } = null!;
}
