using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("ModuleDefId", "ModuleId", Name = "IX_Modules_ModuleDefId")]
[Index("PortalId", Name = "IX_Modules_PortalId")]
public partial class Modules
{
    [Key]
    [Column("ModuleID")]
    public int ModuleId { get; set; }

    [Column("ModuleDefID")]
    public int ModuleDefId { get; set; }

    public bool AllTabs { get; set; }

    public bool IsDeleted { get; set; }

    public bool? InheritViewPermissions { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

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

    [Column("ContentItemID")]
    public int? ContentItemId { get; set; }

    public bool IsShareable { get; set; }

    public bool IsShareableViewOnly { get; set; }

    [ForeignKey("ContentItemId")]
    [InverseProperty("Modules")]
    public virtual ContentItems? ContentItem { get; set; }

    [InverseProperty("Module")]
    public virtual ICollection<CoreMessagingSubscriptions> CoreMessagingSubscriptions { get; set; } = new List<CoreMessagingSubscriptions>();

    [InverseProperty("Module")]
    public virtual ICollection<HtmlText> HtmlText { get; set; } = new List<HtmlText>();

    [ForeignKey("ModuleDefId")]
    [InverseProperty("Modules")]
    public virtual ModuleDefinitions ModuleDef { get; set; } = null!;

    [InverseProperty("Module")]
    public virtual ICollection<ModulePermission> ModulePermission { get; set; } = new List<ModulePermission>();

    [InverseProperty("Module")]
    public virtual ICollection<ModuleSettings> ModuleSettings { get; set; } = new List<ModuleSettings>();

    [InverseProperty("Module")]
    public virtual ICollection<TabModules> TabModules { get; set; } = new List<TabModules>();

    [InverseProperty("Module")]
    public virtual ICollection<WnsInjInjection> WnsInjInjection { get; set; } = new List<WnsInjInjection>();
}
