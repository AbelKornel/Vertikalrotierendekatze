using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[PrimaryKey("SearchObjectId", "WordId", "SiteId")]
[Table("hcc_SearchObjectWords")]
public partial class HccSearchObjectWords
{
    [Key]
    public long SearchObjectId { get; set; }

    [Key]
    public long WordId { get; set; }

    public int Score { get; set; }

    [Key]
    public long SiteId { get; set; }

    [ForeignKey("SearchObjectId")]
    [InverseProperty("HccSearchObjectWords")]
    public virtual HccSearchObjects SearchObject { get; set; } = null!;

    [ForeignKey("WordId")]
    [InverseProperty("HccSearchObjectWords")]
    public virtual HccSearchLexicon Word { get; set; } = null!;
}
