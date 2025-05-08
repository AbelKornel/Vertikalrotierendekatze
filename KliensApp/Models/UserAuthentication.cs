using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("UserId", "AuthenticationType", Name = "IX_UserAuthentication", IsUnique = true)]
public partial class UserAuthentication
{
    [Key]
    [Column("UserAuthenticationID")]
    public int UserAuthenticationId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [StringLength(100)]
    public string AuthenticationType { get; set; } = null!;

    [StringLength(1000)]
    public string AuthenticationToken { get; set; } = null!;

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("UserAuthentication")]
    public virtual Users User { get; set; } = null!;
}
