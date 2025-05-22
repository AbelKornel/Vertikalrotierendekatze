using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Keyless]
public partial class VwEventLog
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

    [Column("LogEventID")]
    public long LogEventId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ExceptionHash { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AssemblyVersion { get; set; }

    public int? PortalId { get; set; }

    public int? UserId { get; set; }

    public int? TabId { get; set; }

    [StringLength(260)]
    public string? RawUrl { get; set; }

    [StringLength(260)]
    public string? Referrer { get; set; }

    [StringLength(260)]
    public string? UserAgent { get; set; }

    [StringLength(500)]
    public string? Message { get; set; }

    public string? StackTrace { get; set; }

    [StringLength(500)]
    public string? InnerMessage { get; set; }

    public string? InnerStackTrace { get; set; }

    [StringLength(500)]
    public string? Source { get; set; }
}
