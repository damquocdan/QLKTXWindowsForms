//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLKTXWindowsForms
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int TransactionID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Description { get; set; }
        public string TransactionCode { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
    
        public virtual Student Student { get; set; }
    }
}
