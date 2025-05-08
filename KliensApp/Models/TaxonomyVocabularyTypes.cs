using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("Taxonomy_VocabularyTypes")]
public partial class TaxonomyVocabularyTypes
{
    [Key]
    [Column("VocabularyTypeID")]
    public int VocabularyTypeId { get; set; }

    [StringLength(50)]
    public string VocabularyType { get; set; } = null!;

    [InverseProperty("VocabularyType")]
    public virtual ICollection<TaxonomyVocabularies> TaxonomyVocabularies { get; set; } = new List<TaxonomyVocabularies>();
}
