using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class Schedule
{
    [Key]
    [Column("ScheduleID")]
    public int ScheduleId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string TypeFullName { get; set; } = null!;

    public int TimeLapse { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string TimeLapseMeasurement { get; set; } = null!;

    public int RetryTimeLapse { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string RetryTimeLapseMeasurement { get; set; } = null!;

    public int RetainHistoryNum { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string AttachToEvent { get; set; } = null!;

    public bool CatchUpEnabled { get; set; }

    public bool Enabled { get; set; }

    [StringLength(300)]
    [Unicode(false)]
    public string ObjectDependencies { get; set; } = null!;

    [StringLength(2000)]
    public string? Servers { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [StringLength(200)]
    public string? FriendlyName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ScheduleStartDate { get; set; }

    [InverseProperty("Schedule")]
    public virtual ICollection<ScheduleHistory> ScheduleHistory { get; set; } = new List<ScheduleHistory>();

    [InverseProperty("Schedule")]
    public virtual ICollection<ScheduleItemSettings> ScheduleItemSettings { get; set; } = new List<ScheduleItemSettings>();
}
