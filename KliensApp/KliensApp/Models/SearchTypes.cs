using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class SearchTypes
{
    [Key]
    public int SearchTypeId { get; set; }

    [StringLength(100)]
    public string SearchTypeName { get; set; } = null!;

    [StringLength(256)]
    public string SearchResultClass { get; set; } = null!;

    public bool? IsPrivate { get; set; }
}
