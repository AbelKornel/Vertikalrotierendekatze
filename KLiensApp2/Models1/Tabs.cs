using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("ParentId", "IsDeleted", Name = "IX_Tabs_ParentId_IsDeleted")]
[Index("PortalId", "Level", "ParentId", "TabOrder", "IsDeleted", Name = "IX_Tabs_PortalLevelParentOrder")]
[Index("UniqueId", Name = "IX_Tabs_UniqueId", IsUnique = true)]
public partial class Tabs
{
    [Key]
    [Column("TabID")]
    public int TabId { get; set; }

    public int TabOrder { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [StringLength(200)]
    public string TabName { get; set; } = null!;

    public bool IsVisible { get; set; }

    public int? ParentId { get; set; }

    [StringLength(255)]
    public string? IconFile { get; set; }

    public bool DisableLink { get; set; }

    [StringLength(200)]
    public string? Title { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [StringLength(500)]
    public string? KeyWords { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(255)]
    public string? Url { get; set; }

    [StringLength(200)]
    public string? SkinSrc { get; set; }

    [StringLength(200)]
    public string? ContainerSrc { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    public int? RefreshInterval { get; set; }

    public string? PageHeadText { get; set; }

    public bool IsSecure { get; set; }

    public bool PermanentRedirect { get; set; }

    public double SiteMapPriority { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [StringLength(255)]
    public string? IconFileLarge { get; set; }

    [StringLength(10)]
    public string? CultureCode { get; set; }

    [Column("ContentItemID")]
    public int? ContentItemId { get; set; }

    public Guid UniqueId { get; set; }

    public Guid VersionGuid { get; set; }

    public Guid? DefaultLanguageGuid { get; set; }

    public Guid LocalizedVersionGuid { get; set; }

    public int Level { get; set; }

    [StringLength(255)]
    public string TabPath { get; set; } = null!;

    public bool HasBeenPublished { get; set; }

    public bool IsSystem { get; set; }

    [ForeignKey("ContentItemId")]
    [InverseProperty("Tabs")]
    public virtual ContentItems? ContentItem { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<Tabs> InverseParent { get; set; } = new List<Tabs>();

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual Tabs? Parent { get; set; }

    [ForeignKey("PortalId")]
    [InverseProperty("Tabs")]
    public virtual Portals? Portal { get; set; }

    [InverseProperty("Tab")]
    public virtual ICollection<TabModules> TabModules { get; set; } = new List<TabModules>();

    [InverseProperty("Tab")]
    public virtual ICollection<TabPermission> TabPermission { get; set; } = new List<TabPermission>();

    [InverseProperty("Tab")]
    public virtual ICollection<TabSettings> TabSettings { get; set; } = new List<TabSettings>();

    [InverseProperty("Tab")]
    public virtual ICollection<TabUrls> TabUrls { get; set; } = new List<TabUrls>();

    [InverseProperty("Tab")]
    public virtual ICollection<TabVersions> TabVersions { get; set; } = new List<TabVersions>();
}
