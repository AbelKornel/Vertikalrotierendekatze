using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[PrimaryKey("ScheduleId", "SettingName")]
public partial class ScheduleItemSettings
{
    [Key]
    [Column("ScheduleID")]
    public int ScheduleId { get; set; }

    [Key]
    [StringLength(50)]
    public string SettingName { get; set; } = null!;

    public string SettingValue { get; set; } = null!;

    [ForeignKey("ScheduleId")]
    [InverseProperty("ScheduleItemSettings")]
    public virtual Schedule Schedule { get; set; } = null!;
}
