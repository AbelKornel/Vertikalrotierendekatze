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
    
    public partial class Journal_Access
    {
        public int JournalAccessId { get; set; }
        public int JournalTypeId { get; set; }
        public int PortalId { get; set; }
        public string Name { get; set; }
        public System.Guid AccessKey { get; set; }
        public bool IsEnabled { get; set; }
        public System.DateTime DateCreated { get; set; }
    }
}
