using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Keyless]
public partial class VwPortalsDefaultLanguage
{
    [Column("PortalID")]
    public int PortalId { get; set; }

    [Column("PortalGroupID")]
    public int? PortalGroupId { get; set; }

    [StringLength(128)]
    public string PortalName { get; set; } = null!;

    [StringLength(546)]
    public string? LogoFile { get; set; }

    [StringLength(100)]
    public string? FooterText { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    public int UserRegistration { get; set; }

    public int BannerAdvertising { get; set; }

    public int? AdministratorId { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? Currency { get; set; }

    [Column(TypeName = "money")]
    public decimal HostFee { get; set; }

    public int HostSpace { get; set; }

    public int PageQuota { get; set; }

    public int UserQuota { get; set; }

    public int? AdministratorRoleId { get; set; }

    public int? RegisteredRoleId { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }

    [StringLength(500)]
    public string? KeyWords { get; set; }

    [StringLength(546)]
    public string? BackgroundFile { get; set; }

    [Column("GUID")]
    public Guid Guid { get; set; }

    [StringLength(50)]
    public string? PaymentProcessor { get; set; }

    [StringLength(50)]
    public string? ProcessorUserId { get; set; }

    [StringLength(100)]
    public string? ProcessorPassword { get; set; }

    public int? SiteLogHistory { get; set; }

    [StringLength(256)]
    public string? Email { get; set; }

    [StringLength(10)]
    public string DefaultLanguage { get; set; } = null!;

    public int TimezoneOffset { get; set; }

    public int? AdminTabId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string HomeDirectory { get; set; } = null!;

    public int? SplashTabId { get; set; }

    public int? HomeTabId { get; set; }

    public int? LoginTabId { get; set; }

    public int? RegisterTabId { get; set; }

    public int? UserTabId { get; set; }

    public int? SearchTabId { get; set; }

    public int? Custom404TabId { get; set; }

    public int? Custom500TabId { get; set; }

    public int? TermsTabId { get; set; }

    public int? PrivacyTabId { get; set; }

    public int? SuperTabId { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [StringLength(10)]
    public string CultureCode { get; set; } = null!;
}
