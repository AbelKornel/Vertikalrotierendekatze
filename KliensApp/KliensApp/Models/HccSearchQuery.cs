using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_SearchQuery")]
public partial class HccSearchQuery
{
    [Key]
    [Column("bvin")]
    [StringLength(36)]
    [Unicode(false)]
    public string Bvin { get; set; } = null!;

    public string QueryPhrase { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string ShopperId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }
}
