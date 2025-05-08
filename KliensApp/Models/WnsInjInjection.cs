using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("wns_inj_injection")]
[Index("ModuleId", Name = "IX_wns_inj_injection_moduleid")]
[Index("ModuleId", "InjectName", Name = "IX_wns_inj_injection_moduleid_injectname")]
[Index("ModuleId", "OrderShown", Name = "IX_wns_inj_injection_moduleid_ordershown")]
public partial class WnsInjInjection
{
    [Key]
    [Column("injection_id")]
    public int InjectionId { get; set; }

    [Column("module_id")]
    public int ModuleId { get; set; }

    [Column("inject_top")]
    public bool InjectTop { get; set; }

    [Column("inject_name")]
    [StringLength(50)]
    public string InjectName { get; set; } = null!;

    [Column("inject_content")]
    public string InjectContent { get; set; } = null!;

    [Column("order_shown")]
    public int OrderShown { get; set; }

    [Column("is_enabled")]
    public bool IsEnabled { get; set; }

    [Column("custom_properties")]
    public string? CustomProperties { get; set; }

    [ForeignKey("ModuleId")]
    [InverseProperty("WnsInjInjection")]
    public virtual Modules Module { get; set; } = null!;
}
