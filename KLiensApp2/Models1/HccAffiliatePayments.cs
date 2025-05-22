using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_AffiliatePayments")]
public partial class HccAffiliatePayments
{
    [Key]
    public long Id { get; set; }

    public long AffiliateId { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal PaymentAmount { get; set; }

    public string? Notes { get; set; }

    [StringLength(500)]
    public string? FileName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PaymentDate { get; set; }

    [ForeignKey("AffiliateId")]
    [InverseProperty("HccAffiliatePayments")]
    public virtual HccAffiliate Affiliate { get; set; } = null!;
}
