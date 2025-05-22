using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_Vendor")]
public partial class HccVendor
{
    [Key]
    [Column("bvin")]
    public Guid Bvin { get; set; }

    [StringLength(255)]
    public string DisplayName { get; set; } = null!;

    [StringLength(255)]
    public string EmailAddress { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string Address { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string DropShipEmailTemplateId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    [InverseProperty("Vendor")]
    public virtual ICollection<HccProduct> HccProduct { get; set; } = new List<HccProduct>();
}
