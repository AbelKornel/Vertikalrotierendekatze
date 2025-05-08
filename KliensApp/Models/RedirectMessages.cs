using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("CreatedOnDate", Name = "IX_RedirectMessages_CreatedOnDate")]
public partial class RedirectMessages
{
    [Key]
    public Guid MessageId { get; set; }

    public int? UserId { get; set; }

    public int? TabId { get; set; }

    public string MessageText { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedOnDate { get; set; }
}
