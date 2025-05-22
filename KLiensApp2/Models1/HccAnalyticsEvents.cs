using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_AnalyticsEvents")]
[Index("StoreId", "ObjectId", "ShoppingSessionGuid", Name = "IX_hcc_AnalyticsEvents")]
public partial class HccAnalyticsEvents
{
    [Key]
    public long AnalyticsEventId { get; set; }

    [StringLength(50)]
    public string? UserId { get; set; }

    public Guid? SessionGuid { get; set; }

    public long StoreId { get; set; }

    [StringLength(50)]
    public string Action { get; set; } = null!;

    public Guid? ObjectId { get; set; }

    public string? AdditionalData { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateTime { get; set; }

    public Guid? ShoppingSessionGuid { get; set; }
}
