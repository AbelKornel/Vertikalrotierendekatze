using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("Mobile_PreviewProfiles")]
[Index("SortOrder", Name = "IX_Mobile_PreviewProfiles_SortOrder")]
public partial class MobilePreviewProfiles
{
    [Key]
    public int Id { get; set; }

    public int PortalId { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    public int Width { get; set; }

    public int Height { get; set; }

    [StringLength(260)]
    public string UserAgent { get; set; } = null!;

    public int SortOrder { get; set; }

    [Column("CreatedByUserID")]
    public int CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastModifiedOnDate { get; set; }

    [ForeignKey("PortalId")]
    [InverseProperty("MobilePreviewProfiles")]
    public virtual Portals Portal { get; set; } = null!;
}
