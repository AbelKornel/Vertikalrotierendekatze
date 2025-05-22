using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_User")]
public partial class HccUser
{
    [Key]
    [Column("bvin")]
    [StringLength(36)]
    [Unicode(false)]
    public string Bvin { get; set; } = null!;

    [StringLength(100)]
    public string Email { get; set; } = null!;

    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [StringLength(100)]
    public string LastName { get; set; } = null!;

    [StringLength(50)]
    public string Password { get; set; } = null!;

    [StringLength(50)]
    public string Salt { get; set; } = null!;

    public int TaxExempt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastLoginDate { get; set; }

    [Column(TypeName = "ntext")]
    public string Comment { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string AddressBook { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public int Locked { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LockedUntil { get; set; }

    public int FailedLoginCount { get; set; }

    public string Phones { get; set; } = null!;

    [StringLength(36)]
    [Unicode(false)]
    public string PricingGroup { get; set; } = null!;

    public string CustomQuestionAnswers { get; set; } = null!;

    public long StoreId { get; set; }

    public string ShippingAddress { get; set; } = null!;

    public string BillingAddress { get; set; } = null!;

    [InverseProperty("User")]
    public virtual ICollection<HccUserXcontact> HccUserXcontact { get; set; } = new List<HccUserXcontact>();
}
