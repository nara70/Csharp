//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOUSE
    {
        public HOUSE()
        {
            this.HOUSEREGIONLINKs = new HashSet<HOUSEREGIONLINK>();
        }
    
        public decimal ID { get; set; }
        public string TYPEOFPROJECT { get; set; }
        public Nullable<decimal> AMOUNTOFFLOORS { get; set; }
        public Nullable<decimal> AMOUNTOFENTRANCES { get; set; }
        public string DATE_ { get; set; }
    
        public virtual ICollection<HOUSEREGIONLINK> HOUSEREGIONLINKs { get; set; }
    }
}