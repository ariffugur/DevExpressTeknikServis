//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevExpressTeknikServis
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLURUNKABUL
    {
        public int ISLEMID { get; set; }
        public Nullable<int> CARI { get; set; }
        public Nullable<short> PERSONEL { get; set; }
        public Nullable<System.DateTime> GELISTARIH { get; set; }
        public Nullable<System.DateTime> CIKISTARIH { get; set; }
        public string URUNSERINO { get; set; }
        public Nullable<bool> URUNDURUM { get; set; }
    
        public virtual TBLCARI TBLCARI { get; set; }
        public virtual TBLPERSONEL TBLPERSONEL { get; set; }
    }
}
