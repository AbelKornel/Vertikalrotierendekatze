using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_Affiliate")]
[Index("AffiliateId", Name = "IX_hcc_Affiliate", IsUnique = true)]
public partial class HccAffiliate
{
    [Key]
    public long Id { get; set; }

    [Column("ReferralID")]
    [StringLength(50)]
    public string? ReferralId { get; set; }

    public bool Enabled { get; set; }

    [Column(TypeName = "numeric(18, 10)")]
    public decimal CommissionAmount { get; set; }

    public int CommissionType { get; set; }

    public int ReferralDays { get; set; }

    [Column("TaxID")]
    [StringLength(100)]
    public string TaxId { get; set; } = null!;

    [StringLength(100)]
    public string DriversLicenseNumber { get; set; } = null!;

    [Column("WebSiteURL")]
    [StringLength(1000)]
    public string WebSiteUrl { get; set; } = null!;

    public string Notes { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    public int UserId { get; set; }

    [Column("AffiliateID")]
    [StringLength(50)]
    public string AffiliateId { get; set; } = null!;

    public bool Approved { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [InverseProperty("Affiliate")]
    public virtual ICollection<HccAffiliatePayments> HccAffiliatePayments { get; set; } = new List<HccAffiliatePayments>();

    [InverseProperty("Affiliate")]
    public virtual ICollection<HccAffiliateReferral> HccAffiliateReferral { get; set; } = new List<HccAffiliateReferral>();
}
