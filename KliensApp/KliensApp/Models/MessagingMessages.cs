using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("Messaging_Messages")]
[Index("EmailSent", "EmailSchedulerInstance", "Status", "Date", Name = "IX_Messaging_Messages_EmailSent_EmailSchedulerInstance_Status", IsDescending = new[] { false, false, false, true })]
[Index("FromUserId", "Status", "Date", Name = "IX_Messaging_Messages_FromUserID_Status", IsDescending = new[] { false, false, true })]
[Index("ToUserId", "Status", "SkipPortal", "Date", Name = "IX_Messaging_Messages_ToUserID_Status_SkipPortal", IsDescending = new[] { false, false, false, true })]
public partial class MessagingMessages
{
    [Key]
    [Column("MessageID")]
    public long MessageId { get; set; }

    [Column("PortalID")]
    public int PortalId { get; set; }

    [Column("FromUserID")]
    public int FromUserId { get; set; }

    [StringLength(50)]
    public string? ToUserName { get; set; }

    [StringLength(50)]
    public string? FromUserName { get; set; }

    [Column("ToUserID")]
    public int? ToUserId { get; set; }

    [Column("ToRoleID")]
    public int? ToRoleId { get; set; }

    public byte Status { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    public Guid Conversation { get; set; }

    public long? ReplyTo { get; set; }

    public bool AllowReply { get; set; }

    public bool SkipPortal { get; set; }

    public bool EmailSent { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EmailSentDate { get; set; }

    public Guid? EmailSchedulerInstance { get; set; }
}
