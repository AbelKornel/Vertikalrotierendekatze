using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Index("ContentItemId", Name = "IX_Journal_ContentItemId")]
public partial class Journal
{
    [Key]
    public int JournalId { get; set; }

    public int JournalTypeId { get; set; }

    public int? UserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateCreated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateUpdated { get; set; }

    public int? PortalId { get; set; }

    public int ProfileId { get; set; }

    public int GroupId { get; set; }

    [StringLength(255)]
    public string? Title { get; set; }

    [StringLength(2000)]
    public string? Summary { get; set; }

    [StringLength(2000)]
    public string? ItemData { get; set; }

    [Column("ImageURL")]
    [StringLength(255)]
    public string? ImageUrl { get; set; }

    [StringLength(255)]
    public string? ObjectKey { get; set; }

    public Guid? AccessKey { get; set; }

    public int? ContentItemId { get; set; }

    public bool IsDeleted { get; set; }

    public bool CommentsDisabled { get; set; }

    public bool CommentsHidden { get; set; }

    [InverseProperty("Journal")]
    public virtual ICollection<JournalComments> JournalComments { get; set; } = new List<JournalComments>();

    [InverseProperty("Journal")]
    public virtual ICollection<JournalData> JournalData { get; set; } = new List<JournalData>();

    [ForeignKey("JournalTypeId")]
    [InverseProperty("Journal")]
    public virtual JournalTypes JournalType { get; set; } = null!;
}
