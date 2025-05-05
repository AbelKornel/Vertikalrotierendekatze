using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class Exceptions
{
    [Key]
    [StringLength(100)]
    [Unicode(false)]
    public string ExceptionHash { get; set; } = null!;

    [StringLength(500)]
    public string Message { get; set; } = null!;

    public string? StackTrace { get; set; }

    [StringLength(500)]
    public string? InnerMessage { get; set; }

    public string? InnerStackTrace { get; set; }

    [StringLength(500)]
    public string? Source { get; set; }
}
