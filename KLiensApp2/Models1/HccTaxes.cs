using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_Taxes")]
public partial class HccTaxes
{
    [Key]
    public long Id { get; set; }

    public long StoreId { get; set; }

    [StringLength(255)]
    public string CountryName { get; set; } = null!;

    [StringLength(255)]
    public string RegionName { get; set; } = null!;

    [StringLength(20)]
    public string PostalCode { get; set; } = null!;

    public long TaxScheduleId { get; set; }

    [Column(TypeName = "numeric(18, 10)")]
    public decimal Rate { get; set; }

    public bool ApplyToShipping { get; set; }

    [Column(TypeName = "numeric(18, 10)")]
    public decimal ShippingRate { get; set; }

    [ForeignKey("StoreId")]
    [InverseProperty("HccTaxes")]
    public virtual HccStores Store { get; set; } = null!;

    [ForeignKey("TaxScheduleId")]
    [InverseProperty("HccTaxes")]
    public virtual HccTaxSchedules TaxSchedule { get; set; } = null!;
}
