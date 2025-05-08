using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Keyless]
public partial class VwDesktopModules
{
    [Column("DesktopModuleID")]
    public int DesktopModuleId { get; set; }

    [StringLength(128)]
    public string FriendlyName { get; set; } = null!;

    [StringLength(2000)]
    public string? Description { get; set; }

    [StringLength(8)]
    public string? Version { get; set; }

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

    [Column("ContentItemID")]
    public int? ContentItemId { get; set; }

    public string? Content { get; set; }

    [Column("ContentTypeID")]
    public int? ContentTypeId { get; set; }

    [Column("TabID")]
    public int? TabId { get; set; }

    [Column("ModuleID")]
    public int? ModuleId { get; set; }

    [StringLength(250)]
    public string? ContentKey { get; set; }

    public bool? Indexed { get; set; }

    public int Shareable { get; set; }

    [StringLength(128)]
    public string? AdminPage { get; set; }

    [StringLength(128)]
    public string? HostPage { get; set; }
}
