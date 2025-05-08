using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("Identifier", Name = "IX_PersonaBarMenu", IsUnique = true)]
public partial class PersonaBarMenu
{
    [Key]
    public int MenuId { get; set; }

    [StringLength(50)]
    public string Identifier { get; set; } = null!;

    [StringLength(50)]
    public string ModuleName { get; set; } = null!;

    [StringLength(50)]
    public string? FolderName { get; set; }

    [StringLength(260)]
    public string? Controller { get; set; }

    [StringLength(50)]
    public string ResourceKey { get; set; } = null!;

    [StringLength(260)]
    public string Path { get; set; } = null!;

    [StringLength(260)]
    public string? Link { get; set; }

    [StringLength(50)]
    public string? CssClass { get; set; }

    public int? ParentId { get; set; }

    public int Order { get; set; }

    public bool AllowHost { get; set; }

    public bool Enabled { get; set; }

    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [StringLength(260)]
    public string? IconFile { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<PersonaBarMenu> InverseParent { get; set; } = new List<PersonaBarMenu>();

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual PersonaBarMenu? Parent { get; set; }

    [InverseProperty("Menu")]
    public virtual ICollection<PersonaBarExtensions> PersonaBarExtensions { get; set; } = new List<PersonaBarExtensions>();

    [InverseProperty("Menu")]
    public virtual PersonaBarMenuDefaultPermissions? PersonaBarMenuDefaultPermissions { get; set; }

    [InverseProperty("Menu")]
    public virtual ICollection<PersonaBarMenuPermission> PersonaBarMenuPermission { get; set; } = new List<PersonaBarMenuPermission>();

    [InverseProperty("Menu")]
    public virtual ICollection<PersonaBarPermission> PersonaBarPermission { get; set; } = new List<PersonaBarPermission>();
}
