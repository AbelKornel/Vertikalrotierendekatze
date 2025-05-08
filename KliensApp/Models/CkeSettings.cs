using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace KliensApp.Models;

[Table("CKE_Settings")]
public partial class CkeSettings
{
    [Key]
    [StringLength(300)]
    public string SettingName { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string SettingValue { get; set; } = null!;
}
