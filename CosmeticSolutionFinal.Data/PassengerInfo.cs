//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CosmeticSolutionFinal.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PassengerInfo
    {
        public System.DateTime Date { get; set; }
        public int StationId { get; set; }
        public int PopulationPerMonth { get; set; }
        public double PercentOfWomen { get; set; }
        public double PercentOfTwentyThirty { get; set; }
        public Nullable<int> OpenTimeEight { get; set; }
        public Nullable<int> OpenTimeNine { get; set; }
        public Nullable<int> CloseTimeNine { get; set; }
        public Nullable<int> CloseTimeTen { get; set; }
    
        public virtual Station Station { get; set; }
    }
}
