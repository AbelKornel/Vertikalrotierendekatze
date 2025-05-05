using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_GiftCard")]
[Index("CardNumber", Name = "UK_hcc_GiftCard", IsUnique = true)]
public partial class HccGiftCard
{
    [Key]
    public long GiftCardId { get; set; }

    public long StoreId { get; set; }

    public long? LineItemId { get; set; }

    [StringLength(50)]
    public string CardNumber { get; set; } = null!;

    [Column(TypeName = "decimal(18, 10)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal UsedAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IssueDateUtc { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpirationDateUtc { get; set; }

    [StringLength(255)]
    public string? RecipientEmail { get; set; }

    [StringLength(255)]
    public string? RecipientName { get; set; }

    public string? GiftMessage { get; set; }

    public bool Enabled { get; set; }
}
