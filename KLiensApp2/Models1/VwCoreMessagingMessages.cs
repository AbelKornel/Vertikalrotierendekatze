using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Keyless]
public partial class VwCoreMessagingMessages
{
    [Column("MessageID")]
    public int MessageId { get; set; }

    [Column("PortalID")]
    public int? PortalId { get; set; }

    [Column("NotificationTypeID")]
    public int? NotificationTypeId { get; set; }

    [StringLength(2000)]
    public string? To { get; set; }

    [StringLength(200)]
    public string? From { get; set; }

    [StringLength(400)]
    public string? Subject { get; set; }

    public string? Body { get; set; }

    [Column("ConversationID")]
    public int? ConversationId { get; set; }

    public bool? ReplyAllAllowed { get; set; }

    [Column("SenderUserID")]
    public int? SenderUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpirationDate { get; set; }

    [StringLength(200)]
    public string? Context { get; set; }

    public bool? IncludeDismissAction { get; set; }

    [Column("CreatedByUserID")]
    public int? CreatedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedOnDate { get; set; }

    [Column("LastModifiedByUserID")]
    public int? LastModifiedByUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastModifiedOnDate { get; set; }

    [Column("RecipientID")]
    public int RecipientId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    public bool Read { get; set; }

    public bool Archived { get; set; }

    public bool EmailSent { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EmailSentDate { get; set; }

    public Guid? EmailSchedulerInstance { get; set; }
}
