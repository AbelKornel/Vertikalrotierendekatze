using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Keyless]
public partial class VwUsers
{
    public int UserId { get; set; }

    public int? PortalId { get; set; }

    [StringLength(100)]
    public string Username { get; set; } = null!;

    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [StringLength(50)]
    public string LastName { get; set; } = null!;

    [StringLength(128)]
    public string DisplayName { get; set; } = null!;

    public bool IsSuperUser { get; set; }

    [StringLength(256)]
    public string? Email { get; set; }

    [StringLength(100)]
    public string? VanityUrl { get; set; }

    public int? AffiliateId { get; set; }

    public bool IsDeleted { get; set; }

    public bool? RefreshRoles { get; set; }

    [Column("LastIPAddress")]
    [StringLength(50)]
    public string? LastIpaddress { get; set; }

    public bool UpdatePassword { get; set; }

    public Guid? PasswordResetToken { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PasswordResetExpiration { get; set; }

    public bool? Authorised { get; set; }

    public bool? HasAgreedToTerms { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HasAgreedToTermsOn { get; set; }

    public bool? RequestsRemoval { get; set; }

    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }
}
