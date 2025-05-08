using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class OutputCache
{
    [Key]
    [StringLength(36)]
    [Unicode(false)]
    public string CacheKey { get; set; } = null!;

    public int ItemId { get; set; }

    public string Data { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Expiration { get; set; }
}
