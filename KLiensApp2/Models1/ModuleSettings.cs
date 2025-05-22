using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[PrimaryKey("ModuleId", "SettingName")]
public partial class ModuleSettings
{
    [Key]
    [Column("ModuleID")]
    public int ModuleId { get; set; }

    [Key]
    [StringLength(50)]
    public string SettingName { get; set; } = null!;

    public string SettingValue { get; set; } = null!;

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [ForeignKey("ModuleId")]
    [InverseProperty("ModuleSettings")]
    public virtual Modules Module { get; set; } = null!;
}
