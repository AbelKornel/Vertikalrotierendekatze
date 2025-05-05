using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class ExceptionEvents
{
    [Key]
    [Column("LogEventID")]
    public long LogEventId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string AssemblyVersion { get; set; } = null!;

    public int? PortalId { get; set; }

    public int? UserId { get; set; }

    public int? TabId { get; set; }

    [StringLength(260)]
    public string? RawUrl { get; set; }

    [StringLength(260)]
    public string? Referrer { get; set; }

    [StringLength(260)]
    public string? UserAgent { get; set; }

    [ForeignKey("LogEventId")]
    [InverseProperty("ExceptionEvents")]
    public virtual EventLog LogEvent { get; set; } = null!;
}
