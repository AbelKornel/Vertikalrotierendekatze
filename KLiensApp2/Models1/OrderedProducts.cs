using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class OrderedProducts
{
    [Key]
    [Column("OrderID")]
    public int OrderId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? ProductName { get; set; }

    public int? Quantity { get; set; }
}
