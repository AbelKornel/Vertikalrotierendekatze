using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[PrimaryKey("UserId", "PortalId")]
[Index("PortalId", Name = "IX_UserPortals")]
[Index("PortalId", "IsDeleted", "Authorised", "UserId", Name = "IX_UserPortals_PortalId_IsDeleted", IsUnique = true, IsDescending = new[] { false, false, true, false })]
[Index("VanityUrl", Name = "IX_UserPortals_VanityUrl")]
public partial class UserPortals
{
    [Key]
    public int UserId { get; set; }

    [Key]
    public int PortalId { get; set; }

    public int UserPortalId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    public bool Authorised { get; set; }

    public bool IsDeleted { get; set; }

    public bool RefreshRoles { get; set; }

    [StringLength(100)]
    public string? VanityUrl { get; set; }

    public bool HasAgreedToTerms { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HasAgreedToTermsOn { get; set; }

    public bool RequestsRemoval { get; set; }

    [ForeignKey("PortalId")]
    [InverseProperty("UserPortals")]
    public virtual Portals Portal { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("UserPortals")]
    public virtual Users User { get; set; } = null!;
}
