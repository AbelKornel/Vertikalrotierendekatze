using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class SearchCommonWords
{
    [Key]
    [Column("CommonWordID")]
    public int CommonWordId { get; set; }

    [StringLength(255)]
    public string CommonWord { get; set; } = null!;

    [StringLength(10)]
    public string? Locale { get; set; }
}
