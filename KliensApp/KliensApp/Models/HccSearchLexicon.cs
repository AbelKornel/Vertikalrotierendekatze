using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_SearchLexicon")]
[Index("Word", "Culture", Name = "IX_hcc_SearchLexicon")]
public partial class HccSearchLexicon
{
    [Key]
    public long Id { get; set; }

    [StringLength(255)]
    public string Word { get; set; } = null!;

    [StringLength(10)]
    public string? Culture { get; set; }

    [InverseProperty("Word")]
    public virtual ICollection<HccSearchObjectWords> HccSearchObjectWords { get; set; } = new List<HccSearchObjectWords>();
}
