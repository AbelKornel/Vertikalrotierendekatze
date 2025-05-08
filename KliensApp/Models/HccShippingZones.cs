using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ShippingZones")]
public partial class HccShippingZones
{
    [Key]
    public long Id { get; set; }

    public long StoreId { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string Areas { get; set; } = null!;

    [ForeignKey("StoreId")]
    [InverseProperty("HccShippingZones")]
    public virtual HccStores Store { get; set; } = null!;
}
