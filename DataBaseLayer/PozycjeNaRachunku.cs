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
    
    public partial class PozycjeNaRachunku
    {
        public int IdPozycji { get; set; }
        public Nullable<double> Ilosc { get; set; }
        public Nullable<double> Cena { get; set; }
        public Nullable<int> IdRachunku { get; set; }
    
        public virtual Rachunki Rachunki { get; set; }
    }
}
