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
    
    public partial class Kasjer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kasjer()
        {
            this.ObslugaRachunkus = new HashSet<ObslugaRachunku>();
            this.ObslugaRaportows = new HashSet<ObslugaRaportow>();
            this.Promocjas = new HashSet<Promocja>();
        }
    
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string haslo { get; set; }
        public int kasjerID { get; set; }
        public string Login { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObslugaRachunku> ObslugaRachunkus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObslugaRaportow> ObslugaRaportows { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Promocja> Promocjas { get; set; }
    }
}
