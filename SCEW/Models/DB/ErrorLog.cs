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
    
    public partial class ErrorLog
    {
        public int Id { get; set; }
        public string InnerException { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public bool isdeleted { get; set; }
    }
}