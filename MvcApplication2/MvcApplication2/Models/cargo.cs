//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class cargo
    {
        public cargo()
        {
            this.useario = new HashSet<useario>();
        }
    
        public int car_cod { get; set; }
        public string car_des { get; set; }
    
        public virtual ICollection<useario> useario { get; set; }
    }
}
