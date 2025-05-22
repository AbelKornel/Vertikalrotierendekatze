using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class SkinPackages
{
    [Key]
    [Column("SkinPackageID")]
    public int SkinPackageId { get; set; }

    [Column("PackageID")]
    public int PackageId { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [StringLength(50)]
    public string SkinName { get; set; } = null!;

    [StringLength(20)]
    public string SkinType { get; set; } = null!;

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [ForeignKey("PackageId")]
    [InverseProperty("SkinPackages")]
    public virtual Packages Package { get; set; } = null!;

    [InverseProperty("SkinPackage")]
    public virtual ICollection<Skins> Skins { get; set; } = new List<Skins>();
}
