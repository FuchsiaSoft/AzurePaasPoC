//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VisitsApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Visit
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public string Comments { get; set; }
    
        public virtual ServiceUser ServiceUser { get; set; }
        public virtual Visitor Visitor { get; set; }
    }
}