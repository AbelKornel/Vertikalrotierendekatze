using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("Username", Name = "IX_Users", IsUnique = true)]
[Index("DisplayName", "IsSuperUser", "IsDeleted", Name = "IX_Users_DisplayName")]
[Index("Email", Name = "IX_Users_Email")]
[Index("IsDeleted", "DisplayName", Name = "IX_Users_IsDeleted_DisplayName")]
[Index("LastModifiedOnDate", Name = "IX_Users_LastModifiedOnDate", AllDescending = true)]
[Index("PasswordResetToken", Name = "IX_Users_PasswordResetToken")]
[Index("Username", "UserId", Name = "IX_Users_UserName_UserID", IsUnique = true)]
public partial class Users
{
    [Key]
    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(100)]
    public string Username { get; set; } = null!;

    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [StringLength(50)]
    public string LastName { get; set; } = null!;

    public bool IsSuperUser { get; set; }

    public int? AffiliateId { get; set; }

    [StringLength(256)]
    public string? Email { get; set; }

    [StringLength(128)]
    public string DisplayName { get; set; } = null!;

    public bool UpdatePassword { get; set; }

    [Column("LastIPAddress")]
    [StringLength(50)]
    public string? LastIpaddress { get; set; }

    public bool IsDeleted { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    public Guid? PasswordResetToken { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PasswordResetExpiration { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<ContentWorkflowStatePermission> ContentWorkflowStatePermission { get; set; } = new List<ContentWorkflowStatePermission>();

    [InverseProperty("User")]
    public virtual ICollection<CoreMessagingSubscriptions> CoreMessagingSubscriptions { get; set; } = new List<CoreMessagingSubscriptions>();

    [InverseProperty("User")]
    public virtual ICollection<DesktopModulePermission> DesktopModulePermission { get; set; } = new List<DesktopModulePermission>();

    [InverseProperty("User")]
    public virtual ICollection<FolderPermission> FolderPermission { get; set; } = new List<FolderPermission>();

    [InverseProperty("User")]
    public virtual ICollection<ModulePermission> ModulePermission { get; set; } = new List<ModulePermission>();

    [InverseProperty("User")]
    public virtual ICollection<PasswordHistory> PasswordHistory { get; set; } = new List<PasswordHistory>();

    [InverseProperty("User")]
    public virtual ICollection<PersonaBarMenuPermission> PersonaBarMenuPermission { get; set; } = new List<PersonaBarMenuPermission>();

    [InverseProperty("User")]
    public virtual ICollection<PortalPermission> PortalPermission { get; set; } = new List<PortalPermission>();

    [InverseProperty("User")]
    public virtual ICollection<Profile> Profile { get; set; } = new List<Profile>();

    [InverseProperty("User")]
    public virtual ICollection<Relationships> Relationships { get; set; } = new List<Relationships>();

    [InverseProperty("User")]
    public virtual ICollection<TabPermission> TabPermission { get; set; } = new List<TabPermission>();

    [InverseProperty("User")]
    public virtual ICollection<UserAuthentication> UserAuthentication { get; set; } = new List<UserAuthentication>();

    [InverseProperty("User")]
    public virtual ICollection<UserPortals> UserPortals { get; set; } = new List<UserPortals>();

    [InverseProperty("User")]
    public virtual ICollection<UserProfile> UserProfile { get; set; } = new List<UserProfile>();

    [InverseProperty("User")]
    public virtual ICollection<UserRelationshipPreferences> UserRelationshipPreferences { get; set; } = new List<UserRelationshipPreferences>();

    [InverseProperty("RelatedUser")]
    public virtual ICollection<UserRelationships> UserRelationshipsRelatedUser { get; set; } = new List<UserRelationships>();

    [InverseProperty("User")]
    public virtual ICollection<UserRelationships> UserRelationshipsUser { get; set; } = new List<UserRelationships>();

    [InverseProperty("User")]
    public virtual ICollection<UserRoles> UserRoles { get; set; } = new List<UserRoles>();

    [InverseProperty("User")]
    public virtual ICollection<UsersOnline> UsersOnline { get; set; } = new List<UsersOnline>();
}
