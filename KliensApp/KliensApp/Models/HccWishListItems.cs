using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_WishListItems")]
[Index("CustomerId", Name = "IX_hcc_WishListItems_CustomerId")]
[Index("StoreId", Name = "IX_hcc_WishListItems_StoreId")]
public partial class HccWishListItems
{
    [Key]
    public long Id { get; set; }

    public long StoreId { get; set; }

    [StringLength(36)]
    public string CustomerId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public Guid ProductId { get; set; }

    public int Quantity { get; set; }

    public string SelectionData { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("HccWishListItems")]
    public virtual HccProduct Product { get; set; } = null!;
}
