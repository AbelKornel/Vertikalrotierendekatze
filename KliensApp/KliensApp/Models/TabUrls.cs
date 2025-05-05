using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[PrimaryKey("TabId", "SeqNum")]
public partial class TabUrls
{
    [Key]
    public int TabId { get; set; }

    [Key]
    public int SeqNum { get; set; }

    [StringLength(200)]
    public string Url { get; set; } = null!;

    [StringLength(200)]
    public string? QueryString { get; set; }

    [StringLength(50)]
    public string HttpStatus { get; set; } = null!;

    [StringLength(50)]
    public string? CultureCode { get; set; }

    public bool IsSystem { get; set; }

    public int? PortalAliasId { get; set; }

    public int? PortalAliasUsage { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [ForeignKey("TabId")]
    [InverseProperty("TabUrls")]
    public virtual Tabs Tab { get; set; } = null!;
}
