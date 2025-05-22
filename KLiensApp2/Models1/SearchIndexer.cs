using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class SearchIndexer
{
    [Key]
    [Column("SearchIndexerID")]
    public int SearchIndexerId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string SearchIndexerAssemblyQualifiedName { get; set; } = null!;
}
