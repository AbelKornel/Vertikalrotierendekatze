//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KLiensApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class hcc_QueuedTasks
    {
        public long Id { get; set; }
        public long StoreId { get; set; }
        public string FriendlyName { get; set; }
        public string TaskProcessorName { get; set; }
        public System.Guid TaskProcessorId { get; set; }
        public string Payload { get; set; }
        public int Status { get; set; }
        public string StatusNotes { get; set; }
        public System.DateTime StartAtUtc { get; set; }
    }
}
