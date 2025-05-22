using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_Address")]
[Index("StoreId", Name = "IX_hcc_Address_StoreId")]
[Index("AddressType", Name = "IX_hcc_Address_Type")]
public partial class HccAddress
{
    public int Id { get; set; }

    [Key]
    [Column("bvin")]
    [StringLength(36)]
    [Unicode(false)]
    public string Bvin { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    [StringLength(255)]
    public string NickName { get; set; } = null!;

    [StringLength(255)]
    public string FirstName { get; set; } = null!;

    [StringLength(1)]
    public string MiddleInitial { get; set; } = null!;

    [StringLength(255)]
    public string LastName { get; set; } = null!;

    [StringLength(255)]
    public string Company { get; set; } = null!;

    [StringLength(255)]
    public string Line1 { get; set; } = null!;

    [StringLength(255)]
    public string Line2 { get; set; } = null!;

    [StringLength(255)]
    public string Line3 { get; set; } = null!;

    [StringLength(255)]
    public string City { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string RegionBvin { get; set; } = null!;

    [StringLength(255)]
    public string RegionName { get; set; } = null!;

    [StringLength(50)]
    public string PostalCode { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string CountryBvin { get; set; } = null!;

    [StringLength(255)]
    public string CountryName { get; set; } = null!;

    [StringLength(50)]
    public string Phone { get; set; } = null!;

    [StringLength(50)]
    public string Fax { get; set; } = null!;

    [StringLength(255)]
    public string WebSiteUrl { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string UserBvin { get; set; } = null!;

    public long StoreId { get; set; }

    public int AddressType { get; set; }
}
