//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Borrow
    {
        public int BoorowID { get; set; }
        public string NatID { get; set; }
        public int BookID { get; set; }
        public System.DateTime TakenDate { get; set; }
        public System.DateTime BroughtDate { get; set; }
        public int Book_Quantity { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
