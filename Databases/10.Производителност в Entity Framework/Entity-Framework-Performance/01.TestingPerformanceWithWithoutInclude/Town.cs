//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _01.TestingPerformanceWithWithoutInclude
{
    using System;
    using System.Collections.Generic;
    
    public partial class Town
    {
        public Town()
        {
            this.Addresses = new HashSet<Address>();
        }
    
        public int TownID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Address> Addresses { get; set; }
    }
}
