using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("PortalId", "MappingName", Name = "IX_FolderMappings", IsUnique = true)]
public partial class FolderMappings
{
    [Key]
    [Column("FolderMappingID")]
    public int FolderMappingId { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [StringLength(50)]
    public string MappingName { get; set; } = null!;

    [StringLength(50)]
    public string FolderProviderType { get; set; } = null!;

    public int? Priority { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [InverseProperty("FolderMapping")]
    public virtual ICollection<FolderMappingsSettings> FolderMappingsSettings { get; set; } = new List<FolderMappingsSettings>();

    [InverseProperty("FolderMapping")]
    public virtual ICollection<Folders> Folders { get; set; } = new List<Folders>();

    [ForeignKey("PortalId")]
    [InverseProperty("FolderMappings")]
    public virtual Portals? Portal { get; set; }
}
