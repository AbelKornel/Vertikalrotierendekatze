using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Keyless]
public partial class VwTabs
{
    [Column("TabID")]
    public int TabId { get; set; }

    public int TabOrder { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [StringLength(200)]
    public string TabName { get; set; } = null!;

    public int? ParentId { get; set; }

    public int Level { get; set; }

    [StringLength(255)]
    public string TabPath { get; set; } = null!;

    public Guid UniqueId { get; set; }

    public Guid VersionGuid { get; set; }

    public Guid? DefaultLanguageGuid { get; set; }

    public Guid LocalizedVersionGuid { get; set; }

    public bool IsVisible { get; set; }

    public bool HasBeenPublished { get; set; }

    [StringLength(546)]
    public string? IconFile { get; set; }

    [StringLength(546)]
    public string? IconFileLarge { get; set; }

    public bool DisableLink { get; set; }

    [StringLength(200)]
    public string? Title { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [StringLength(500)]
    public string? KeyWords { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(200)]
    public string? SkinSrc { get; set; }

    [StringLength(200)]
    public string? ContainerSrc { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [StringLength(255)]
    public string? Url { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string HasChildren { get; set; } = null!;

    public int? RefreshInterval { get; set; }

    public string? PageHeadText { get; set; }

    public bool IsSecure { get; set; }

    public bool PermanentRedirect { get; set; }

    public double SiteMapPriority { get; set; }

    [Column("ContentItemID")]
    public int? ContentItemId { get; set; }

    public string? Content { get; set; }

    [Column("ContentTypeID")]
    public int? ContentTypeId { get; set; }

    [Column("ModuleID")]
    public int? ModuleId { get; set; }

    [StringLength(250)]
    public string? ContentKey { get; set; }

    public bool? Indexed { get; set; }

    [Column("StateID")]
    public int? StateId { get; set; }

    [StringLength(10)]
    public string? CultureCode { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    public bool IsSystem { get; set; }
}
