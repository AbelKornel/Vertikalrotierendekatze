using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_Stores")]
public partial class HccStores
{
    [Key]
    public long Id { get; set; }

    public Guid StoreGuid { get; set; }

    [StringLength(255)]
    public string StoreName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DateCreated { get; set; }

    [StringLength(255)]
    public string CustomUrl { get; set; } = null!;

    public int LastOrderNumber { get; set; }

    [InverseProperty("Store")]
    public virtual ICollection<HccOrderTransactions> HccOrderTransactions { get; set; } = new List<HccOrderTransactions>();

    [InverseProperty("Store")]
    public virtual ICollection<HccShippingZones> HccShippingZones { get; set; } = new List<HccShippingZones>();

    [InverseProperty("Store")]
    public virtual ICollection<HccStoreSettings> HccStoreSettings { get; set; } = new List<HccStoreSettings>();

    [InverseProperty("Store")]
    public virtual ICollection<HccStoresXusers> HccStoresXusers { get; set; } = new List<HccStoresXusers>();

    [InverseProperty("Store")]
    public virtual ICollection<HccTaxSchedules> HccTaxSchedules { get; set; } = new List<HccTaxSchedules>();

    [InverseProperty("Store")]
    public virtual ICollection<HccTaxes> HccTaxes { get; set; } = new List<HccTaxes>();
}
