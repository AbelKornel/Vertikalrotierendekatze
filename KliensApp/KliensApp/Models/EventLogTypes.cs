using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class EventLogTypes
{
    [Key]
    [StringLength(35)]
    public string LogTypeKey { get; set; } = null!;

    [StringLength(50)]
    public string LogTypeFriendlyName { get; set; } = null!;

    [StringLength(128)]
    public string LogTypeDescription { get; set; } = null!;

    [StringLength(100)]
    public string LogTypeOwner { get; set; } = null!;

    [Column("LogTypeCSSClass")]
    [StringLength(40)]
    public string LogTypeCssclass { get; set; } = null!;

    [InverseProperty("LogTypeKeyNavigation")]
    public virtual ICollection<EventLog> EventLog { get; set; } = new List<EventLog>();

    [InverseProperty("LogTypeKeyNavigation")]
    public virtual ICollection<EventLogConfig> EventLogConfig { get; set; } = new List<EventLogConfig>();
}
