using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("Taxonomy_Vocabularies")]
public partial class TaxonomyVocabularies
{
    [Key]
    [Column("VocabularyID")]
    public int VocabularyId { get; set; }

    [Column("VocabularyTypeID")]
    public int VocabularyTypeId { get; set; }

    [StringLength(250)]
    public string Name { get; set; } = null!;

    [StringLength(2500)]
    public string? Description { get; set; }

    public int Weight { get; set; }

    [Column("ScopeID")]
    public int? ScopeId { get; set; }

    [Column("ScopeTypeID")]
    public int ScopeTypeId { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    public bool IsSystem { get; set; }

    [ForeignKey("ScopeTypeId")]
    [InverseProperty("TaxonomyVocabularies")]
    public virtual TaxonomyScopeTypes ScopeType { get; set; } = null!;

    [InverseProperty("Vocabulary")]
    public virtual ICollection<TaxonomyTerms> TaxonomyTerms { get; set; } = new List<TaxonomyTerms>();

    [ForeignKey("VocabularyTypeId")]
    [InverseProperty("TaxonomyVocabularies")]
    public virtual TaxonomyVocabularyTypes VocabularyType { get; set; } = null!;
}
