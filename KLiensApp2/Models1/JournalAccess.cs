using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("Journal_Access")]
public partial class JournalAccess
{
    [Key]
    public int JournalAccessId { get; set; }

    public int JournalTypeId { get; set; }

    public int PortalId { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    public Guid AccessKey { get; set; }

    public bool IsEnabled { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateCreated { get; set; }
}
