using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class UrlLog
{
    [Key]
    [Column("UrlLogID")]
    public int UrlLogId { get; set; }

    [Column("UrlTrackingID")]
    public int UrlTrackingId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ClickDate { get; set; }

    [Column("UserID")]
    public int? UserId { get; set; }

    [ForeignKey("UrlTrackingId")]
    [InverseProperty("UrlLog")]
    public virtual UrlTracking UrlTracking { get; set; } = null!;
}
