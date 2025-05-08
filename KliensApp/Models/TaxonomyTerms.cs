using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("Taxonomy_Terms")]
public partial class TaxonomyTerms
{
    [Key]
    [Column("TermID")]
    public int TermId { get; set; }

    [Column("VocabularyID")]
    public int VocabularyId { get; set; }

    [Column("ParentTermID")]
    public int? ParentTermId { get; set; }

    [StringLength(250)]
    public string Name { get; set; } = null!;

    [StringLength(2500)]
    public string? Description { get; set; }

    public int Weight { get; set; }

    public int TermLeft { get; set; }

    public int TermRight { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [InverseProperty("Term")]
    public virtual ICollection<ContentItemsTags> ContentItemsTags { get; set; } = new List<ContentItemsTags>();

    [InverseProperty("ParentTerm")]
    public virtual ICollection<TaxonomyTerms> InverseParentTerm { get; set; } = new List<TaxonomyTerms>();

    [ForeignKey("ParentTermId")]
    [InverseProperty("InverseParentTerm")]
    public virtual TaxonomyTerms? ParentTerm { get; set; }

    [ForeignKey("VocabularyId")]
    [InverseProperty("TaxonomyTerms")]
    public virtual TaxonomyVocabularies Vocabulary { get; set; } = null!;
}
