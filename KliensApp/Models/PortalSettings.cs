using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class PortalSettings
{
    [Key]
    [Column("PortalSettingID")]
    public int PortalSettingId { get; set; }

    [Column("PortalID")]
    public int PortalId { get; set; }

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

    [StringLength(10)]
    public string? CultureCode { get; set; }

    public bool IsSecure { get; set; }

    [ForeignKey("PortalId")]
    [InverseProperty("PortalSettings")]
    public virtual Portals Portal { get; set; } = null!;
}
