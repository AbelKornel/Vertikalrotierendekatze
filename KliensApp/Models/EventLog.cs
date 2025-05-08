using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("LogConfigId", "LogNotificationPending", "LogCreateDate", Name = "IX_EventLog_LogConfigID")]
[Index("LogCreateDate", Name = "IX_EventLog_LogCreateDate")]
[Index("LogGuid", Name = "IX_EventLog_LogGUID")]
[Index("LogTypeKey", "LogPortalId", Name = "IX_EventLog_LogType")]
public partial class EventLog
{
    [Column("LogGUID")]
    [StringLength(36)]
    [Unicode(false)]
    public string LogGuid { get; set; } = null!;

    [StringLength(35)]
    public string LogTypeKey { get; set; } = null!;

    [Column("LogConfigID")]
    public int? LogConfigId { get; set; }

    [Column("LogUserID")]
    public int? LogUserId { get; set; }

    [StringLength(50)]
    public string? LogUserName { get; set; }

    [Column("LogPortalID")]
    public int? LogPortalId { get; set; }

    [StringLength(100)]
    public string? LogPortalName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LogCreateDate { get; set; }

    [StringLength(50)]
    public string LogServerName { get; set; } = null!;

    [Column(TypeName = "xml")]
    public string? LogProperties { get; set; }

    public bool? LogNotificationPending { get; set; }

    [Key]
    [Column("LogEventID")]
    public long LogEventId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ExceptionHash { get; set; }

    [InverseProperty("LogEvent")]
    public virtual ExceptionEvents? ExceptionEvents { get; set; }

    [ForeignKey("LogConfigId")]
    [InverseProperty("EventLog")]
    public virtual EventLogConfig? LogConfig { get; set; }

    [ForeignKey("LogTypeKey")]
    [InverseProperty("EventLog")]
    public virtual EventLogTypes LogTypeKeyNavigation { get; set; } = null!;
}
