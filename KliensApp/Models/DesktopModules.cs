using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("FriendlyName", Name = "IX_DesktopModules_FriendlyName")]
[Index("ModuleName", Name = "IX_DesktopModules_ModuleName", IsUnique = true)]
public partial class DesktopModules
{
    [Key]
    [Column("DesktopModuleID")]
    public int DesktopModuleId { get; set; }

    [StringLength(128)]
    public string FriendlyName { get; set; } = null!;

    [StringLength(2000)]
    public string? Description { get; set; }

    [StringLength(50)]
    public string Version { get; set; } = null!;

    public bool IsPremium { get; set; }

    public bool IsAdmin { get; set; }

    [StringLength(200)]
    public string? BusinessControllerClass { get; set; }

    [StringLength(128)]
    public string FolderName { get; set; } = null!;

    [StringLength(128)]
    public string ModuleName { get; set; } = null!;

    public int SupportedFeatures { get; set; }

    [StringLength(500)]
    public string? CompatibleVersions { get; set; }

    [StringLength(400)]
    public string? Dependencies { get; set; }

    [StringLength(400)]
    public string? Permissions { get; set; }

    [Column("PackageID")]
    public int PackageId { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    public int ContentItemId { get; set; }

    public int Shareable { get; set; }

    [StringLength(128)]
    public string? AdminPage { get; set; }

    [StringLength(128)]
    public string? HostPage { get; set; }

    [InverseProperty("DesktopModule")]
    public virtual ICollection<CoreMessagingNotificationTypes> CoreMessagingNotificationTypes { get; set; } = new List<CoreMessagingNotificationTypes>();

    [InverseProperty("DesktopModule")]
    public virtual ICollection<ModuleDefinitions> ModuleDefinitions { get; set; } = new List<ModuleDefinitions>();

    [ForeignKey("PackageId")]
    [InverseProperty("DesktopModules")]
    public virtual Packages Package { get; set; } = null!;

    [InverseProperty("DesktopModule")]
    public virtual ICollection<PortalDesktopModules> PortalDesktopModules { get; set; } = new List<PortalDesktopModules>();
}
