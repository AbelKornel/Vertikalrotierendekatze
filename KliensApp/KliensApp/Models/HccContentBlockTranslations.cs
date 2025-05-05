using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ContentBlockTranslations")]
[Index("ContentBlockId", "Culture", Name = "UK_hcc_ContentBlockTranslations", IsUnique = true)]
public partial class HccContentBlockTranslations
{
    [Key]
    public long ContentBlockTranslationId { get; set; }

    public Guid ContentBlockId { get; set; }

    [StringLength(10)]
    public string Culture { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string? TextSettings { get; set; }

    [ForeignKey("ContentBlockId")]
    [InverseProperty("HccContentBlockTranslations")]
    public virtual HccContentBlock ContentBlock { get; set; } = null!;
}
