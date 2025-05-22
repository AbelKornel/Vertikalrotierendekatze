using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_CatalogRoles")]
public partial class HccCatalogRoles
{
    [Key]
    public long CatalogRoleId { get; set; }

    [StringLength(250)]
    public string? RoleName { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? CategoryId { get; set; }

    public Guid? ProductTypeId { get; set; }

    public long StoreId { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("HccCatalogRoles")]
    public virtual HccCategory? Category { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("HccCatalogRoles")]
    public virtual HccProduct? Product { get; set; }

    [ForeignKey("ProductTypeId")]
    [InverseProperty("HccCatalogRoles")]
    public virtual HccProductType? ProductType { get; set; }
}
