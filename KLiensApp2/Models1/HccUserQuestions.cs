using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("hcc_UserQuestions")]
public partial class HccUserQuestions
{
    [Key]
    [Column("bvin")]
    [StringLength(36)]
    [Unicode(false)]
    public string Bvin { get; set; } = null!;

    [StringLength(50)]
    public string QuestionName { get; set; } = null!;

    public int QuestionType { get; set; }

    public string Values { get; set; } = null!;

    public int Order { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LastUpdated { get; set; }

    public long StoreId { get; set; }
}
