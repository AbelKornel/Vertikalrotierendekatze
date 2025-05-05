using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("Identifier", Name = "IX_PersonaBarExtensions", IsUnique = true)]
public partial class PersonaBarExtensions
{
    [Key]
    public int ExtensionId { get; set; }

    [StringLength(50)]
    public string Identifier { get; set; } = null!;

    public int MenuId { get; set; }

    [StringLength(50)]
    public string? FolderName { get; set; }

    [StringLength(260)]
    public string? Controller { get; set; }

    [StringLength(50)]
    public string Container { get; set; } = null!;

    [StringLength(260)]
    public string Path { get; set; } = null!;

    public int Order { get; set; }

    public bool Enabled { get; set; }

    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [ForeignKey("MenuId")]
    [InverseProperty("PersonaBarExtensions")]
    public virtual PersonaBarMenu Menu { get; set; } = null!;
}
