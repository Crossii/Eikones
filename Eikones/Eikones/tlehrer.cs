//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eikones
{
    using System;
    using System.Collections.Generic;
    
    public partial class tlehrer
    {
        public tlehrer()
        {
            this.tklassens = new HashSet<tklassen>();
            this.tpruefungens = new HashSet<tpruefungen>();
            this.tunterrichts = new HashSet<tunterricht>();
        }
    
        public string L_ID { get; set; }
        public string L_Zuname { get; set; }
        public string L_Vorname { get; set; }
        public string L_Email { get; set; }
    
        public virtual ICollection<tklassen> tklassens { get; set; }
        public virtual ICollection<tpruefungen> tpruefungens { get; set; }
        public virtual ICollection<tunterricht> tunterrichts { get; set; }
    }
}
