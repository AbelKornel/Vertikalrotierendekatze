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
    
    public partial class HtmlTextUsers
    {
        public int HtmlTextUserID { get; set; }
        public int ItemID { get; set; }
        public int StateID { get; set; }
        public int ModuleID { get; set; }
        public int TabID { get; set; }
        public int UserID { get; set; }
        public System.DateTime CreatedOnDate { get; set; }
    
        public virtual HtmlText HtmlText { get; set; }
    }
}
