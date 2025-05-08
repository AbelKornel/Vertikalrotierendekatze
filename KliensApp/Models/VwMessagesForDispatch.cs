using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Keyless]
public partial class VwMessagesForDispatch
{
    [Column("UserID")]
    public int UserId { get; set; }

    [Column("RecipientID")]
    public int RecipientId { get; set; }

    public Guid? EmailSchedulerInstance { get; set; }

    public int EmailFrequency { get; set; }
}
