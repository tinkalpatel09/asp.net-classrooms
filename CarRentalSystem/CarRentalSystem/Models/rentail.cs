//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class rentail
    {
        public int id { get; set; }
        public string carid { get; set; }
        public Nullable<int> custid { get; set; }
        public Nullable<int> fee { get; set; }
        public Nullable<System.DateTime> sdate { get; set; }
        public Nullable<System.DateTime> edate { get; set; }
    }
}
