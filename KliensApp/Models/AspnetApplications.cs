using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("aspnet_Applications")]
[Index("LoweredApplicationName", Name = "UQ__aspnet_A__17477DE4D699761B", IsUnique = true)]
[Index("ApplicationName", Name = "UQ__aspnet_A__3091033104C576C4", IsUnique = true)]
public partial class AspnetApplications
{
    [StringLength(256)]
    public string ApplicationName { get; set; } = null!;

    [StringLength(256)]
    public string LoweredApplicationName { get; set; } = null!;

    [Key]
    public Guid ApplicationId { get; set; }

    [StringLength(256)]
    public string? Description { get; set; }

    [InverseProperty("Application")]
    public virtual ICollection<AspnetMembership> AspnetMembership { get; set; } = new List<AspnetMembership>();

    [InverseProperty("Application")]
    public virtual ICollection<AspnetUsers> AspnetUsers { get; set; } = new List<AspnetUsers>();
}
