using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("Taxonomy_ScopeTypes")]
public partial class TaxonomyScopeTypes
{
    [Key]
    [Column("ScopeTypeID")]
    public int ScopeTypeId { get; set; }

    [StringLength(250)]
    public string? ScopeType { get; set; }

    [InverseProperty("ScopeType")]
    public virtual ICollection<TaxonomyVocabularies> TaxonomyVocabularies { get; set; } = new List<TaxonomyVocabularies>();
}
