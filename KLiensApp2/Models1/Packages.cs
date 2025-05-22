using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("Owner", "Name", "PackageType", "PortalId", "Version", Name = "IX_Packages", IsUnique = true)]
public partial class Packages
{
    [Key]
    [Column("PackageID")]
    public int PackageId { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [StringLength(128)]
    public string Name { get; set; } = null!;

    [StringLength(250)]
    public string FriendlyName { get; set; } = null!;

    [StringLength(2000)]
    public string? Description { get; set; }

    [StringLength(100)]
    public string PackageType { get; set; } = null!;

    [StringLength(50)]
    public string Version { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string? License { get; set; }

    [Column(TypeName = "ntext")]
    public string? Manifest { get; set; }

    [StringLength(100)]
    public string? Owner { get; set; }

    [StringLength(100)]
    public string? Organization { get; set; }

    [StringLength(250)]
    public string? Url { get; set; }

    [StringLength(100)]
    public string? Email { get; set; }

    [Column(TypeName = "ntext")]
    public string? ReleaseNotes { get; set; }

    public bool IsSystemPackage { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [StringLength(128)]
    public string? FolderName { get; set; }

    [StringLength(100)]
    public string? IconFile { get; set; }

    [InverseProperty("Package")]
    public virtual ICollection<Assemblies> Assemblies { get; set; } = new List<Assemblies>();

    [InverseProperty("Package")]
    public virtual ICollection<Authentication> Authentication { get; set; } = new List<Authentication>();

    [InverseProperty("Package")]
    public virtual ICollection<DesktopModules> DesktopModules { get; set; } = new List<DesktopModules>();

    [InverseProperty("Package")]
    public virtual ICollection<JavaScriptLibraries> JavaScriptLibraries { get; set; } = new List<JavaScriptLibraries>();

    [InverseProperty("Package")]
    public virtual ICollection<LanguagePacks> LanguagePacks { get; set; } = new List<LanguagePacks>();

    [InverseProperty("Package")]
    public virtual ICollection<PackageDependencies> PackageDependencies { get; set; } = new List<PackageDependencies>();

    [ForeignKey("PackageType")]
    [InverseProperty("Packages")]
    public virtual PackageTypes PackageTypeNavigation { get; set; } = null!;

    [InverseProperty("Package")]
    public virtual ICollection<SkinControls> SkinControls { get; set; } = new List<SkinControls>();

    [InverseProperty("Package")]
    public virtual ICollection<SkinPackages> SkinPackages { get; set; } = new List<SkinPackages>();
}
