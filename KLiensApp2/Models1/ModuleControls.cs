using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("ModuleDefId", "ControlKey", "ControlSrc", Name = "IX_ModuleControls", IsUnique = true)]
[Index("ControlKey", "ViewOrder", Name = "IX_ModuleControls_ControlKey_ViewOrder")]
public partial class ModuleControls
{
    [Key]
    [Column("ModuleControlID")]
    public int ModuleControlId { get; set; }

    [Column("ModuleDefID")]
    public int? ModuleDefId { get; set; }

    [StringLength(50)]
    public string? ControlKey { get; set; }

    [StringLength(50)]
    public string? ControlTitle { get; set; }

    [StringLength(256)]
    public string? ControlSrc { get; set; }

    [StringLength(100)]
    public string? IconFile { get; set; }

    public int ControlType { get; set; }

    public int? ViewOrder { get; set; }

    [StringLength(200)]
    public string? HelpUrl { get; set; }

    public bool SupportsPartialRendering { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    public bool SupportsPopUps { get; set; }

    [ForeignKey("ModuleDefId")]
    [InverseProperty("ModuleControls")]
    public virtual ModuleDefinitions? ModuleDef { get; set; }
}
