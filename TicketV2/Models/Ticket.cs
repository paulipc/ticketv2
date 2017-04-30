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
    
    public partial class Ticket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ticket()
        {
            this.Detail = new HashSet<Detail>();
        }
    
        public int TicketID { get; set; }
        public System.DateTime Created { get; set; }
        public string UserID { get; set; }
        public string ContactOrg { get; set; }
        public string ContactEU { get; set; }
        public string Contact { get; set; }
        public string ContactTel { get; set; }
        public string ContactEmail { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detail> Detail { get; set; }
    }
}
