using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("ContentItems_Tags")]
[Index("ContentItemId", "TermId", Name = "IX_ContentItems_Tags", IsUnique = true)]
[Index("TermId", Name = "IX_ContentItems_Tags_TermID")]
public partial class ContentItemsTags
{
    [Key]
    [Column("ContentItemTagID")]
    public int ContentItemTagId { get; set; }

    [Column("ContentItemID")]
    public int ContentItemId { get; set; }

    [Column("TermID")]
    public int TermId { get; set; }

    [ForeignKey("ContentItemId")]
    [InverseProperty("ContentItemsTags")]
    public virtual ContentItems ContentItem { get; set; } = null!;

    [ForeignKey("TermId")]
    [InverseProperty("ContentItemsTags")]
    public virtual TaxonomyTerms Term { get; set; } = null!;
}
