using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_OrderNote")]
[Index("OrderId", Name = "IX_hcc_OrderNote")]
public partial class HccOrderNote
{
    [Key]
    public long Id { get; set; }

    public Guid OrderId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AuditDate { get; set; }

    public string Note { get; set; } = null!;

    public bool IsPublic { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedUtc { get; set; }

    public long StoreId { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("HccOrderNote")]
    public virtual HccOrder Order { get; set; } = null!;
}
