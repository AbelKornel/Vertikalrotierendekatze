using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

public partial class EventQueue
{
    [Key]
    [Column("EventMessageID")]
    public int EventMessageId { get; set; }

    [StringLength(100)]
    public string EventName { get; set; } = null!;

    public int Priority { get; set; }

    [StringLength(250)]
    public string ProcessorType { get; set; } = null!;

    [StringLength(250)]
    public string ProcessorCommand { get; set; } = null!;

    [StringLength(250)]
    public string Body { get; set; } = null!;

    [StringLength(250)]
    public string Sender { get; set; } = null!;

    [StringLength(100)]
    public string Subscriber { get; set; } = null!;

    [StringLength(250)]
    public string AuthorizedRoles { get; set; } = null!;

    [StringLength(250)]
    public string ExceptionMessage { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime SentDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpirationDate { get; set; }

    [Column(TypeName = "ntext")]
    public string Attributes { get; set; } = null!;

    public bool IsComplete { get; set; }
}
