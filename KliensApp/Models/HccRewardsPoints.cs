using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_RewardsPoints")]
[Index("UserId", Name = "IX_hcc_RewardsPoints")]
[Index("StoreId", Name = "IX_hcc_RewardsPoints_1")]
public partial class HccRewardsPoints
{
    [Key]
    public long Id { get; set; }

    [StringLength(50)]
    public string UserId { get; set; } = null!;

    public int Points { get; set; }

    public int PointsHeld { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TransactionTime { get; set; }

    public long StoreId { get; set; }
}
