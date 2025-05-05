using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_MembershipProductType")]
public partial class HccMembershipProductType
{
    [Key]
    public Guid ProductTypeBvin { get; set; }

    [StringLength(250)]
    public string RoleName { get; set; } = null!;

    public int ExpirationPeriod { get; set; }

    public int ExpirationPeriodType { get; set; }

    public bool Notify { get; set; }

    [ForeignKey("ProductTypeBvin")]
    [InverseProperty("HccMembershipProductType")]
    public virtual HccProductType ProductTypeBvinNavigation { get; set; } = null!;
}
