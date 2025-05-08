using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_CategoryXProperty")]
public partial class HccCategoryXproperty
{
    [Key]
    public long Id { get; set; }

    [StringLength(36)]
    public string CategoryId { get; set; } = null!;

    public long PropertyId { get; set; }

    public long ParentPropertyId { get; set; }

    public int SortOrder { get; set; }

    [StringLength(255)]
    public string FilterName { get; set; } = null!;

    public int DisplayMode { get; set; }

    public long StoreId { get; set; }
}
