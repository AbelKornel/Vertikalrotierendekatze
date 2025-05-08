using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_SearchObjects")]
public partial class HccSearchObjects
{
    [Key]
    public long Id { get; set; }

    public int ObjectType { get; set; }

    public Guid ObjectId { get; set; }

    [StringLength(512)]
    public string Title { get; set; } = null!;

    public long SiteId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastIndexUtc { get; set; }

    [InverseProperty("SearchObject")]
    public virtual ICollection<HccSearchObjectWords> HccSearchObjectWords { get; set; } = new List<HccSearchObjectWords>();
}
