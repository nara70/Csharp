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
    
    public partial class HOUSEREGIONLINK
    {
        public decimal ID { get; set; }
        public Nullable<decimal> HOUSE_ID { get; set; }
        public Nullable<decimal> REGION_ID { get; set; }
    
        public virtual CITYREGION CITYREGION { get; set; }
        public virtual HOUSE HOUSE { get; set; }
    }
}
