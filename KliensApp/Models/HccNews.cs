using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_News")]
public partial class HccNews
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TimeStampUtc { get; set; }

    public string Message { get; set; } = null!;
}
