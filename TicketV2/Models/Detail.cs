//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketV2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detail
    {
        public int DetailID { get; set; }
        public int TicketID { get; set; }
        public System.DateTime Created { get; set; }
        public string UserID { get; set; }
        public string DDescription { get; set; }
    
        public virtual Ticket Ticket { get; set; }
    }
}
