using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_OrderCoupon")]
[Index("OrderBvin", Name = "IX_hcc_OrderCoupon_OrderBvin")]
public partial class HccOrderCoupon
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdatedUtc { get; set; }

    [StringLength(50)]
    public string CouponCode { get; set; } = null!;

    public Guid OrderBvin { get; set; }

    public long StoreId { get; set; }

    [StringLength(36)]
    [Unicode(false)]
    public string UserId { get; set; } = null!;

    public bool IsUsed { get; set; }

    [ForeignKey("OrderBvin")]
    [InverseProperty("HccOrderCoupon")]
    public virtual HccOrder OrderBvinNavigation { get; set; } = null!;
}
