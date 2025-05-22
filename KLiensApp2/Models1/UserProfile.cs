using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("UserId", Name = "IX_UserProfile")]
[Index("LastUpdatedDate", Name = "IX_UserProfile_LastUpdatedDate", AllDescending = true)]
[Index("PropertyDefinitionId", Name = "IX_UserProfile_PropertyDefinitionID")]
[Index("UserId", "PropertyDefinitionId", Name = "IX_UserProfile_UserID_PropertyDefinitionID")]
[Index("UserId", "ProfileId", Name = "IX_UserProfile_Visibility")]
public partial class UserProfile
{
    [Key]
    [Column("ProfileID")]
    public int ProfileId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [Column("PropertyDefinitionID")]
    public int PropertyDefinitionId { get; set; }

    [StringLength(3750)]
    public string? PropertyValue { get; set; }

    public string? PropertyText { get; set; }

    public int Visibility { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedDate { get; set; }

    [StringLength(400)]
    [Unicode(false)]
    public string? ExtendedVisibility { get; set; }

    [ForeignKey("PropertyDefinitionId")]
    [InverseProperty("UserProfile")]
    public virtual ProfilePropertyDefinition PropertyDefinition { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("UserProfile")]
    public virtual Users User { get; set; } = null!;
}
