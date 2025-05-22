using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("ModuleId", "TabId", Name = "IX_TabModules_ModuleID")]
[Index("TabId", "PaneName", "ModuleOrder", Name = "IX_TabModules_ModuleOrder")]
[Index("TabId", "ModuleId", Name = "IX_TabModules_TabID", IsUnique = true)]
[Index("UniqueId", Name = "IX_TabModules_UniqueId", IsUnique = true)]
public partial class TabModules
{
    [Key]
    [Column("TabModuleID")]
    public int TabModuleId { get; set; }

    [Column("TabID")]
    public int TabId { get; set; }

    [Column("ModuleID")]
    public int ModuleId { get; set; }

    [StringLength(50)]
    public string PaneName { get; set; } = null!;

    public int ModuleOrder { get; set; }

    public int CacheTime { get; set; }

    [StringLength(10)]
    public string? Alignment { get; set; }

    [StringLength(20)]
    public string? Color { get; set; }

    [StringLength(1)]
    public string? Border { get; set; }

    [StringLength(100)]
    public string? IconFile { get; set; }

    public int Visibility { get; set; }

    [StringLength(200)]
    public string? ContainerSrc { get; set; }

    public bool DisplayTitle { get; set; }

    public bool DisplayPrint { get; set; }

    public bool DisplaySyndicate { get; set; }

    public bool IsWebSlice { get; set; }

    [StringLength(256)]
    public string? WebSliceTitle { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? WebSliceExpiryDate { get; set; }

    [Column("WebSliceTTL")]
    public int? WebSliceTtl { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    public bool IsDeleted { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CacheMethod { get; set; }

    [StringLength(256)]
    public string? ModuleTitle { get; set; }

    public string? Header { get; set; }

    public string? Footer { get; set; }

    [StringLength(10)]
    public string? CultureCode { get; set; }

    public Guid UniqueId { get; set; }

    public Guid VersionGuid { get; set; }

    public Guid? DefaultLanguageGuid { get; set; }

    public Guid LocalizedVersionGuid { get; set; }

    [ForeignKey("ModuleId")]
    [InverseProperty("TabModules")]
    public virtual Modules Module { get; set; } = null!;

    [ForeignKey("TabId")]
    [InverseProperty("TabModules")]
    public virtual Tabs Tab { get; set; } = null!;

    [InverseProperty("TabModule")]
    public virtual ICollection<TabModuleSettings> TabModuleSettings { get; set; } = new List<TabModuleSettings>();
}
