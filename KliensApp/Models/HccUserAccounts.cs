using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_UserAccounts")]
public partial class HccUserAccounts
{
    [Key]
    public long Id { get; set; }

    [Column("email")]
    [StringLength(255)]
    public string Email { get; set; } = null!;

    [Column("password")]
    [StringLength(255)]
    public string Password { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DateCreated { get; set; }

    [Column("statuscode")]
    public int Statuscode { get; set; }

    [StringLength(50)]
    public string Salt { get; set; } = null!;

    [StringLength(50)]
    public string ResetKey { get; set; } = null!;

    [InverseProperty("User")]
    public virtual ICollection<HccAuthTokens> HccAuthTokens { get; set; } = new List<HccAuthTokens>();

    [InverseProperty("User")]
    public virtual ICollection<HccStoresXusers> HccStoresXusers { get; set; } = new List<HccStoresXusers>();
}
