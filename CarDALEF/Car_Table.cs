//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarDALEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car_Table
    {
        public Car_Table()
        {
            this.RCB_Table = new HashSet<RCB_Table>();
        }
    
        public int CA_ID { get; set; }
        public string CA_RegNo { get; set; }
        public string CA_Color { get; set; }
        public int CA_Model { get; set; }
        public string CA_Company { get; set; }
        public bool CA_Status { get; set; }
    
        public virtual ICollection<RCB_Table> RCB_Table { get; set; }
    }
}
