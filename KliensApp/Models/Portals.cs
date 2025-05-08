using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("AdministratorId", Name = "IX_Portals_AdministratorId")]
[Index("DefaultLanguage", Name = "IX_Portals_DefaultLanguage")]
public partial class Portals
{
    [Key]
    [Column("PortalID")]
    public int PortalId { get; set; }

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

    public int? AdministratorRoleId { get; set; }

    public int? RegisteredRoleId { get; set; }

    [Column("GUID")]
    public Guid Guid { get; set; }

    [StringLength(50)]
    public string? PaymentProcessor { get; set; }

    [StringLength(50)]
    public string? ProcessorUserId { get; set; }

    [StringLength(100)]
    public string? ProcessorPassword { get; set; }

    public int? SiteLogHistory { get; set; }

    [StringLength(10)]
    public string DefaultLanguage { get; set; } = null!;

    public int TimezoneOffset { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string HomeDirectory { get; set; } = null!;

    public int PageQuota { get; set; }

    public int UserQuota { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [Column("PortalGroupID")]
    public int? PortalGroupId { get; set; }

    [InverseProperty("Portal")]
    public virtual ICollection<AnonymousUsers> AnonymousUsers { get; set; } = new List<AnonymousUsers>();

    [InverseProperty("Portal")]
    public virtual ICollection<CoreMessagingSubscriptions> CoreMessagingSubscriptions { get; set; } = new List<CoreMessagingSubscriptions>();

    [InverseProperty("Portal")]
    public virtual ICollection<Files> Files { get; set; } = new List<Files>();

    [InverseProperty("Portal")]
    public virtual ICollection<FolderMappings> FolderMappings { get; set; } = new List<FolderMappings>();

    [InverseProperty("Portal")]
    public virtual ICollection<Folders> Folders { get; set; } = new List<Folders>();

    [InverseProperty("Portal")]
    public virtual ICollection<MobilePreviewProfiles> MobilePreviewProfiles { get; set; } = new List<MobilePreviewProfiles>();

    [InverseProperty("Portal")]
    public virtual ICollection<MobileRedirections> MobileRedirections { get; set; } = new List<MobileRedirections>();

    [InverseProperty("Portal")]
    public virtual ICollection<PersonaBarMenuPermission> PersonaBarMenuPermission { get; set; } = new List<PersonaBarMenuPermission>();

    [InverseProperty("Portal")]
    public virtual ICollection<PortalAlias> PortalAlias { get; set; } = new List<PortalAlias>();

    [InverseProperty("Portal")]
    public virtual ICollection<PortalDesktopModules> PortalDesktopModules { get; set; } = new List<PortalDesktopModules>();

    [InverseProperty("Portal")]
    public virtual ICollection<PortalLanguages> PortalLanguages { get; set; } = new List<PortalLanguages>();

    [InverseProperty("Portal")]
    public virtual ICollection<PortalLocalization> PortalLocalization { get; set; } = new List<PortalLocalization>();

    [InverseProperty("Portal")]
    public virtual ICollection<PortalPermission> PortalPermission { get; set; } = new List<PortalPermission>();

    [InverseProperty("Portal")]
    public virtual ICollection<PortalSettings> PortalSettings { get; set; } = new List<PortalSettings>();

    [InverseProperty("Portal")]
    public virtual ICollection<Profile> Profile { get; set; } = new List<Profile>();

    [InverseProperty("Portal")]
    public virtual ICollection<ProfilePropertyDefinition> ProfilePropertyDefinition { get; set; } = new List<ProfilePropertyDefinition>();

    [InverseProperty("Portal")]
    public virtual ICollection<Relationships> Relationships { get; set; } = new List<Relationships>();

    [InverseProperty("Portal")]
    public virtual ICollection<RoleGroups> RoleGroups { get; set; } = new List<RoleGroups>();

    [InverseProperty("Portal")]
    public virtual ICollection<Roles> Roles { get; set; } = new List<Roles>();

    [InverseProperty("Portal")]
    public virtual ICollection<SiteLog> SiteLog { get; set; } = new List<SiteLog>();

    [InverseProperty("Portal")]
    public virtual ICollection<SystemMessages> SystemMessages { get; set; } = new List<SystemMessages>();

    [InverseProperty("Portal")]
    public virtual ICollection<Tabs> Tabs { get; set; } = new List<Tabs>();

    [InverseProperty("Portal")]
    public virtual ICollection<UrlTracking> UrlTracking { get; set; } = new List<UrlTracking>();

    [InverseProperty("Portal")]
    public virtual ICollection<Urls> Urls { get; set; } = new List<Urls>();

    [InverseProperty("Portal")]
    public virtual ICollection<UserPortals> UserPortals { get; set; } = new List<UserPortals>();

    [InverseProperty("Portal")]
    public virtual ICollection<UsersOnline> UsersOnline { get; set; } = new List<UsersOnline>();
}
