using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[PrimaryKey("PortalId", "CultureCode")]
public partial class PortalLocalization
{
    [Key]
    [Column("PortalID")]
    public int PortalId { get; set; }

    [Key]
    [StringLength(10)]
    public string CultureCode { get; set; } = null!;

    [StringLength(128)]
    public string PortalName { get; set; } = null!;

    [StringLength(50)]
    public string? LogoFile { get; set; }

    [StringLength(100)]
    public string? FooterText { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [StringLength(500)]
    public string? KeyWords { get; set; }

    [StringLength(50)]
    public string? BackgroundFile { get; set; }

    public int? HomeTabId { get; set; }

    public int? LoginTabId { get; set; }

    public int? UserTabId { get; set; }

    public int? AdminTabId { get; set; }

    public int? SplashTabId { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    public int? RegisterTabId { get; set; }

    public int? SearchTabId { get; set; }

    public int? Custom404TabId { get; set; }

    public int? Custom500TabId { get; set; }

    public int? TermsTabId { get; set; }

    public int? PrivacyTabId { get; set; }

    [ForeignKey("PortalId")]
    [InverseProperty("PortalLocalization")]
    public virtual Portals Portal { get; set; } = null!;
}
