using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_AffiliateReferral")]
public partial class HccAffiliateReferral
{
    [Key]
    public long Id { get; set; }

    public long AffiliateId { get; set; }

    [Column("referrerurl")]
    [StringLength(1000)]
    public string Referrerurl { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime TimeOfReferralUtc { get; set; }

    public long StoreId { get; set; }

    [ForeignKey("AffiliateId")]
    [InverseProperty("HccAffiliateReferral")]
    public virtual HccAffiliate Affiliate { get; set; } = null!;
}
