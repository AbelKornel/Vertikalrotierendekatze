using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("DefinitionName", Name = "IX_ModuleDefinitions", IsUnique = true)]
[Index("DesktopModuleId", Name = "IX_ModuleDefinitions_1")]
public partial class ModuleDefinitions
{
    [Key]
    [Column("ModuleDefID")]
    public int ModuleDefId { get; set; }

    [StringLength(128)]
    public string FriendlyName { get; set; } = null!;

    [Column("DesktopModuleID")]
    public int DesktopModuleId { get; set; }

    public int DefaultCacheTime { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [StringLength(128)]
    public string DefinitionName { get; set; } = null!;

    [ForeignKey("DesktopModuleId")]
    [InverseProperty("ModuleDefinitions")]
    public virtual DesktopModules DesktopModule { get; set; } = null!;

    [InverseProperty("ModuleDef")]
    public virtual ICollection<ModuleControls> ModuleControls { get; set; } = new List<ModuleControls>();

    [InverseProperty("ModuleDef")]
    public virtual ICollection<Modules> Modules { get; set; } = new List<Modules>();
}
