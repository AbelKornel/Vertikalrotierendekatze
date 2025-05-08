using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_OrderTransactions")]
[Index("OrderId", Name = "IX_hcc_OrderTransactions_OrderId")]
[Index("StoreId", Name = "IX_hcc_OrderTransactions_StoreId")]
public partial class HccOrderTransactions
{
    [Key]
    public Guid Id { get; set; }

    public long StoreId { get; set; }

    public Guid OrderId { get; set; }

    [StringLength(50)]
    public string OrderNumber { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Timestamp { get; set; }

    public int Action { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "ntext")]
    public string CreditCard { get; set; } = null!;

    public bool Success { get; set; }

    public bool Voided { get; set; }

    [StringLength(255)]
    public string RefNum1 { get; set; } = null!;

    [StringLength(255)]
    public string RefNum2 { get; set; } = null!;

    [StringLength(50)]
    public string LinkedToTransaction { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string Messages { get; set; } = null!;

    [StringLength(50)]
    public string CheckNumber { get; set; } = null!;

    [StringLength(50)]
    public string PurchaseOrderNumber { get; set; } = null!;

    [StringLength(50)]
    public string CompanyAccountNumber { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string AdditionalSettings { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string? GiftCard { get; set; }

    [StringLength(50)]
    public string? MethodId { get; set; }

    public long? LineItemId { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("HccOrderTransactions")]
    public virtual HccOrder Order { get; set; } = null!;

    [ForeignKey("StoreId")]
    [InverseProperty("HccOrderTransactions")]
    public virtual HccStores Store { get; set; } = null!;
}
