//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public System.DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public string Status { get; set; }
    
        public virtual Order Order1 { get; set; }
        public virtual Order Order2 { get; set; }
    }
}
