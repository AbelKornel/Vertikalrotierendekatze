using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("Mobile_RedirectionRules")]
public partial class MobileRedirectionRules
{
    [Key]
    public int Id { get; set; }

    public int RedirectionId { get; set; }

    [StringLength(50)]
    public string Capability { get; set; } = null!;

    [StringLength(50)]
    public string Expression { get; set; } = null!;

    [ForeignKey("RedirectionId")]
    [InverseProperty("MobileRedirectionRules")]
    public virtual MobileRedirections Redirection { get; set; } = null!;
}
