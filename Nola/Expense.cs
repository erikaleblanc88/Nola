//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nola
{
    using System;
    using System.Collections.Generic;
    
    public partial class Expense
    {
        public int IdExpense { get; set; }
        public string description { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<int> idCar { get; set; }
        public Nullable<System.DateTime> date { get; set; }
    
        public virtual Car Car { get; set; }
    }
}
