//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCEW.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserLog
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public string UserAction { get; set; }
        public System.DateTime Log_DateTime { get; set; }
    
        public virtual User User { get; set; }
    }
}