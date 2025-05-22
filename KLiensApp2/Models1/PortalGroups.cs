using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class PortalGroups
{
    [Key]
    [Column("PortalGroupID")]
    public int PortalGroupId { get; set; }

    [Column("MasterPortalID")]
    public int? MasterPortalId { get; set; }

    [StringLength(100)]
    public string? PortalGroupName { get; set; }

    [StringLength(2000)]
    public string? PortalGroupDescription { get; set; }

    [StringLength(200)]
    public string? AuthenticationDomain { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }
}
