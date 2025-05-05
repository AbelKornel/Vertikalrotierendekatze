using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_ProductReview")]
[Index("Id", Name = "IX_hcc_ProductReview", IsUnique = true)]
public partial class HccProductReview
{
    public int Id { get; set; }

    [Column("lastUpdated", TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    [Key]
    [Column("bvin")]
    public Guid Bvin { get; set; }

    public int Approved { get; set; }

    public string Description { get; set; } = null!;

    public int Karma { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReviewDate { get; set; }

    public int Rating { get; set; }

    [Column("UserID")]
    [StringLength(36)]
    [Unicode(false)]
    public string UserId { get; set; } = null!;

    public long StoreId { get; set; }

    public Guid ProductId { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("HccProductReview")]
    public virtual HccProduct Product { get; set; } = null!;
}
