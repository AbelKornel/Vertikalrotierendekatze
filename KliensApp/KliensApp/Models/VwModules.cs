using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Keyless]
public partial class VwModules
{
    [Column("OwnerPortalID")]
    public int? OwnerPortalId { get; set; }

    [Column("PackageID")]
    public int PackageId { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [Column("TabID")]
    public int? TabId { get; set; }

    [Column("TabModuleID")]
    public int? TabModuleId { get; set; }

    [Column("ModuleID")]
    public int ModuleId { get; set; }

    [Column("ModuleDefID")]
    public int ModuleDefId { get; set; }

    public int? ModuleOrder { get; set; }

    [StringLength(50)]
    public string? PaneName { get; set; }

    [StringLength(256)]
    public string? ModuleTitle { get; set; }

    public int? CacheTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CacheMethod { get; set; }

    [StringLength(10)]
    public string? Alignment { get; set; }

    [StringLength(20)]
    public string? Color { get; set; }

    [StringLength(1)]
    public string? Border { get; set; }

    [StringLength(546)]
    public string? IconFile { get; set; }

    public int? Visibility { get; set; }

    public string? Header { get; set; }

    public string? Footer { get; set; }

    [StringLength(200)]
    public string? ContainerSrc { get; set; }

    public bool? DisplayTitle { get; set; }

    public bool? DisplayPrint { get; set; }

    public bool? DisplaySyndicate { get; set; }

    public bool? IsWebSlice { get; set; }

    [StringLength(256)]
    public string? WebSliceTitle { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? WebSliceExpiryDate { get; set; }

    [Column("WebSliceTTL")]
    public int? WebSliceTtl { get; set; }

    public Guid? UniqueId { get; set; }

    public Guid? VersionGuid { get; set; }

    public Guid? DefaultLanguageGuid { get; set; }

    public Guid? LocalizedVersionGuid { get; set; }

    [StringLength(10)]
    public string? CultureCode { get; set; }

    public bool AllTabs { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TabStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TabEndDate { get; set; }

    public bool? InheritViewPermissions { get; set; }

    public bool IsShareable { get; set; }

    public bool IsShareableViewOnly { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastContentModifiedOnDate { get; set; }

    [Column("DesktopModuleID")]
    public int DesktopModuleId { get; set; }

    public int DefaultCacheTime { get; set; }

    [StringLength(128)]
    public string DefinitionName { get; set; } = null!;

    [Column("ModuleControlID")]
    public int ModuleControlId { get; set; }

    [StringLength(200)]
    public string? BusinessControllerClass { get; set; }

    public bool IsAdmin { get; set; }

    public int SupportedFeatures { get; set; }

    [Column("ContentItemID")]
    public int? ContentItemId { get; set; }

    public string? Content { get; set; }

    [Column("ContentTypeID")]
    public int? ContentTypeId { get; set; }

    [StringLength(250)]
    public string? ContentKey { get; set; }

    public bool? Indexed { get; set; }

    [Column("StateID")]
    public int? StateId { get; set; }

    public bool? IsDeleted { get; set; }

    public bool IsModuleDeleted { get; set; }

    public bool? IsTabDeleted { get; set; }
}
