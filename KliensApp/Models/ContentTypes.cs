using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("ContentType", Name = "IX_ContentTypes_ContentType", IsUnique = true)]
public partial class ContentTypes
{
    [Key]
    [Column("ContentTypeID")]
    public int ContentTypeId { get; set; }

    [StringLength(100)]
    public string ContentType { get; set; } = null!;

    [InverseProperty("ContentType")]
    public virtual ICollection<ContentItems> ContentItems { get; set; } = new List<ContentItems>();

    [InverseProperty("ContentType")]
    public virtual ICollection<ContentWorkflowActions> ContentWorkflowActions { get; set; } = new List<ContentWorkflowActions>();
}
