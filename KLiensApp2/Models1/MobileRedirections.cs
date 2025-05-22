using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("Mobile_Redirections")]
[Index("SortOrder", Name = "IX_Mobile_Redirections_SortOrder")]
public partial class MobileRedirections
{
    [Key]
    public int Id { get; set; }

    public int PortalId { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    public int Type { get; set; }

    public int SortOrder { get; set; }

    public int SourceTabId { get; set; }

    public bool IncludeChildTabs { get; set; }

    public int TargetType { get; set; }

    [StringLength(260)]
    public string TargetValue { get; set; } = null!;

    public bool Enabled { get; set; }

    [Column("CreatedByUserID")]
    public int CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastModifiedOnDate { get; set; }

    [InverseProperty("Redirection")]
    public virtual ICollection<MobileRedirectionRules> MobileRedirectionRules { get; set; } = new List<MobileRedirectionRules>();

    [ForeignKey("PortalId")]
    [InverseProperty("MobileRedirections")]
    public virtual Portals Portal { get; set; } = null!;
}
