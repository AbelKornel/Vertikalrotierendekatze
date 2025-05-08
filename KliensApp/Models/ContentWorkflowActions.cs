using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("ContentTypeId", "ActionType", Name = "ContentTypeId_ActionType", IsUnique = true)]
public partial class ContentWorkflowActions
{
    [Key]
    public int ActionId { get; set; }

    public int ContentTypeId { get; set; }

    [StringLength(50)]
    public string ActionType { get; set; } = null!;

    [StringLength(256)]
    public string ActionSource { get; set; } = null!;

    [ForeignKey("ContentTypeId")]
    [InverseProperty("ContentWorkflowActions")]
    public virtual ContentTypes ContentType { get; set; } = null!;
}
