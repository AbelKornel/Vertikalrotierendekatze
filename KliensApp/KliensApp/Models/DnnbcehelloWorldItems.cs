using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("DNNBCEHelloWorld_Items")]
public partial class DnnbcehelloWorldItems
{
    [Key]
    public int ItemId { get; set; }

    public string ItemName { get; set; } = null!;

    public string ItemDescription { get; set; } = null!;

    public int? AssignedUserId { get; set; }

    public int ModuleId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOnDate { get; set; }

    public int CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastModifiedOnDate { get; set; }

    public int LastModifiedByUserId { get; set; }
}
