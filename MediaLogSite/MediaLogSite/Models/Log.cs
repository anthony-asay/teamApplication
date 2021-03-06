//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediaLogSite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Log
    {
        public int LogID { get; set; }
        public string Title { get; set; }
        public Nullable<decimal> Rating { get; set; }
        public Nullable<decimal> Time { get; set; }
        public int UserID { get; set; }
        public int MediaID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }

        public virtual Medium Medium { get; set; }
        public virtual User User { get; set; }
    }
}
