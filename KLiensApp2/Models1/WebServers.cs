using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("ServerName", "IisappName", Name = "IX_WebServers_ServerName", IsUnique = true)]
public partial class WebServers
{
    [Key]
    [Column("ServerID")]
    public int ServerId { get; set; }

    [StringLength(50)]
    public string ServerName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastActivityDate { get; set; }

    [Column("URL")]
    [StringLength(255)]
    public string? Url { get; set; }

    [Column("IISAppName")]
    [StringLength(200)]
    public string IisappName { get; set; } = null!;

    public bool Enabled { get; set; }

    [StringLength(200)]
    public string? ServerGroup { get; set; }

    [StringLength(200)]
    public string? UniqueId { get; set; }

    public int PingFailureCount { get; set; }
}
