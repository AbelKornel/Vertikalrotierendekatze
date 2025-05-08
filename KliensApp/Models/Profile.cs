using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("UserId", "PortalId", Name = "IX_Profile", IsUnique = true)]
public partial class Profile
{
    [Key]
    public int ProfileId { get; set; }

    public int UserId { get; set; }

    public int PortalId { get; set; }

    [Column(TypeName = "ntext")]
    public string ProfileData { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [ForeignKey("PortalId")]
    [InverseProperty("Profile")]
    public virtual Portals Portal { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("Profile")]
    public virtual Users User { get; set; } = null!;
}
