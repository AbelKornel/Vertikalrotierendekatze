using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("Journal_Data")]
public partial class JournalData
{
    [Key]
    public int JournalDataId { get; set; }

    public int JournalId { get; set; }

    [Column("JournalXML", TypeName = "xml")]
    public string JournalXml { get; set; } = null!;

    [ForeignKey("JournalId")]
    [InverseProperty("JournalData")]
    public virtual Journal Journal { get; set; } = null!;
}
