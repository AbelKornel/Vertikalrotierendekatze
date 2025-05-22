using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("DateCreated", Name = "IX_SearchDeletedItems_DateCreated")]
public partial class SearchDeletedItems
{
    [Key]
    [Column("SearchDeletedItemsID")]
    public int SearchDeletedItemsId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateCreated { get; set; }

    public string? Document { get; set; }
}
