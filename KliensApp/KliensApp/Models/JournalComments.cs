using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("Journal_Comments")]
public partial class JournalComments
{
    [Key]
    public int CommentId { get; set; }

    public int JournalId { get; set; }

    public int UserId { get; set; }

    [StringLength(2000)]
    public string? Comment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateCreated { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DateUpdated { get; set; }

    [Column("CommentXML", TypeName = "xml")]
    public string? CommentXml { get; set; }

    [ForeignKey("JournalId")]
    [InverseProperty("JournalComments")]
    public virtual Journal Journal { get; set; } = null!;
}
