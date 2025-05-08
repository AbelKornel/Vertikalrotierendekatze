using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("MenuId", Name = "IX_PersonaBarMenuDefaultPermissions", IsUnique = true)]
public partial class PersonaBarMenuDefaultPermissions
{
    [Key]
    public int Id { get; set; }

    public int MenuId { get; set; }

    [StringLength(1024)]
    public string RoleNames { get; set; } = null!;

    [ForeignKey("MenuId")]
    [InverseProperty("PersonaBarMenuDefaultPermissions")]
    public virtual PersonaBarMenu Menu { get; set; } = null!;
}
