//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLCuocDTMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThongTinSIM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThongTinSIM()
        {
            this.ChiTietSuDungs = new HashSet<ChiTietSuDung>();
            this.HoaDonDangKies = new HashSet<HoaDonDangKy>();
            this.HoaDonTinhCuocs = new HashSet<HoaDonTinhCuoc>();
        }
    
        public string IDSIM { get; set; }
        public string MaKH { get; set; }
        public Nullable<System.DateTime> NgayDangKy { get; set; }
        public Nullable<System.DateTime> NgayHetHan { get; set; }
        public Nullable<bool> Flag { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSuDung> ChiTietSuDungs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonDangKy> HoaDonDangKies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonTinhCuoc> HoaDonTinhCuocs { get; set; }
        public virtual KhachHang KhachHang { get; set; }
    }
}
