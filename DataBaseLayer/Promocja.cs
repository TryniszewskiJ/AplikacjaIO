//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Promocja
    {
        public string nazwaPromocji { get; set; }
        public string opisPromocji { get; set; }
        public int promocjaID { get; set; }
        public Nullable<int> kierownikID { get; set; }
        public System.DateTime DataWdrozenia { get; set; }
    
        public virtual Kierownik Kierownik { get; set; }
    }
}
