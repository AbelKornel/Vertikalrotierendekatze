using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class SearchStopWords
{
    [Key]
    [Column("StopWordsID")]
    public int StopWordsId { get; set; }

    public string StopWords { get; set; } = null!;

    [Column("CreatedByUserID")]
    public int CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastModifiedOnDate { get; set; }

    [Column("PortalID")]
    public int PortalId { get; set; }

    [StringLength(50)]
    public string CultureCode { get; set; } = null!;
}
