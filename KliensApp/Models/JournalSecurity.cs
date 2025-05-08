using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("Journal_Security")]
[Index("JournalId", "SecurityKey", Name = "IX_Journal_Security", IsUnique = true)]
public partial class JournalSecurity
{
    [Key]
    public int JournalSecurityId { get; set; }

    public int JournalId { get; set; }

    [StringLength(50)]
    public string SecurityKey { get; set; } = null!;
}
