using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class SynonymsGroups
{
    [Key]
    [Column("SynonymsGroupID")]
    public int SynonymsGroupId { get; set; }

    public string SynonymsTags { get; set; } = null!;

    [Column("PortalID")]
    public int PortalId { get; set; }

    [StringLength(50)]
    public string CultureCode { get; set; } = null!;

    [Column("CreatedByUserID")]
    public int CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastModifiedOnDate { get; set; }
}
