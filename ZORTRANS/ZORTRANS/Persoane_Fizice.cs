//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZORTRANS
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class Persoane_Fizice
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int ID_CLIENT { get; set; }
        public int ID_LOCATIE { get; set; }
        public string CNP { get; set; }
    
        public virtual Clienti Clienti { get; set; }
        public virtual Locatii Locatii { get; set; }
    }
}