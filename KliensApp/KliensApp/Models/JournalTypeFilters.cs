using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("Journal_TypeFilters")]
public partial class JournalTypeFilters
{
    [Key]
    public int JournalTypeFilterId { get; set; }

    public int PortalId { get; set; }

    public int ModuleId { get; set; }

    public int JournalTypeId { get; set; }
}
