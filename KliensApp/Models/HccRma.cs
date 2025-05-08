using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_RMA")]
[Index("OrderBvin", Name = "IX_hcc_RMA_OrderBvin")]
public partial class HccRma
{
    [Key]
    [Column("bvin")]
    public Guid Bvin { get; set; }

    public Guid OrderBvin { get; set; }

    [StringLength(150)]
    public string Name { get; set; } = null!;

    public int Number { get; set; }

    [StringLength(150)]
    public string EmailAddress { get; set; } = null!;

    [StringLength(30)]
    public string PhoneNumber { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public int Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateOfReturn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }

    [InverseProperty("RmabvinNavigation")]
    public virtual ICollection<HccRmaitem> HccRmaitem { get; set; } = new List<HccRmaitem>();

    [ForeignKey("OrderBvin")]
    [InverseProperty("HccRma")]
    public virtual HccOrder OrderBvinNavigation { get; set; } = null!;
}
