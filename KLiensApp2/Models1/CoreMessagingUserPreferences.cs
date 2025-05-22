using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("CoreMessaging_UserPreferences")]
public partial class CoreMessagingUserPreferences
{
    [Key]
    public int UserPreferenceId { get; set; }

    public int PortalId { get; set; }

    public int UserId { get; set; }

    public int MessagesEmailFrequency { get; set; }

    public int NotificationsEmailFrequency { get; set; }
}
