using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("LogTypeKey", "LogTypePortalId", Name = "IX_LogTypeKey_LogTypePortalID", IsUnique = true)]
public partial class EventLogConfig
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(35)]
    public string? LogTypeKey { get; set; }

    [Column("LogTypePortalID")]
    public int? LogTypePortalId { get; set; }

    public bool LoggingIsActive { get; set; }

    public int KeepMostRecent { get; set; }

    public bool EmailNotificationIsActive { get; set; }

    public int? NotificationThreshold { get; set; }

    public int? NotificationThresholdTime { get; set; }

    public int? NotificationThresholdTimeType { get; set; }

    [StringLength(50)]
    public string MailFromAddress { get; set; } = null!;

    [StringLength(50)]
    public string MailToAddress { get; set; } = null!;

    [InverseProperty("LogConfig")]
    public virtual ICollection<EventLog> EventLog { get; set; } = new List<EventLog>();

    [ForeignKey("LogTypeKey")]
    [InverseProperty("EventLogConfig")]
    public virtual EventLogTypes? LogTypeKeyNavigation { get; set; }
}
