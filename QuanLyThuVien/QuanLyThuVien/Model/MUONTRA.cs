//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyThuVien.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MUONTRA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MUONTRA()
        {
            this.CHITIETMUONTRAs = new HashSet<CHITIETMUONTRA>();
        }
    
        public string MaMuonTra { get; set; }
        public string MaThe { get; set; }
        public string MaNhanVien { get; set; }
        public Nullable<System.DateTime> NgayMuon { get; set; }
        public Nullable<System.DateTime> NgayTra { get; set; }
        public string Ghichu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETMUONTRA> CHITIETMUONTRAs { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual THETHUVIEN THETHUVIEN { get; set; }
    }
}
