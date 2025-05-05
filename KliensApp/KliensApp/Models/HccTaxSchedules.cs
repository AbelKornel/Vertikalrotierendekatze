using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_TaxSchedules")]
public partial class HccTaxSchedules
{
    [Key]
    public long Id { get; set; }

    public long StoreId { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column(TypeName = "decimal(18, 10)")]
    public decimal DefaultRate { get; set; }

    [Column(TypeName = "decimal(18, 10)")]
    public decimal DefaultShippingRate { get; set; }

    [InverseProperty("TaxSchedule")]
    public virtual ICollection<HccTaxes> HccTaxes { get; set; } = new List<HccTaxes>();

    [ForeignKey("StoreId")]
    [InverseProperty("HccTaxSchedules")]
    public virtual HccStores Store { get; set; } = null!;
}
