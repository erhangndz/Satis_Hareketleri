//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Satis_Hareketleri
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblHareketler
    {
        public short HareketID { get; set; }
        public Nullable<byte> Urun { get; set; }
        public Nullable<byte> Musteri { get; set; }
        public Nullable<byte> Personel { get; set; }
        public Nullable<short> Fiyat { get; set; }
    
        public virtual TblMusteri TblMusteri { get; set; }
        public virtual TblPersoneller TblPersoneller { get; set; }
        public virtual TblUrunler TblUrunler { get; set; }
    }
}
