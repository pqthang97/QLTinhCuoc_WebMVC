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
    
    public partial class HoaDonTinhCuoc
    {
        public string MaHDTC { get; set; }
        public string IDSIM { get; set; }
        public Nullable<decimal> PhiThueBao { get; set; }
        public Nullable<decimal> TongTien { get; set; }
        public Nullable<System.DateTime> NgayLapHD { get; set; }
        public Nullable<bool> ThanhToan { get; set; }
        public Nullable<bool> Flag { get; set; }
    
        public virtual ThongTinSIM ThongTinSIM { get; set; }
    }
}
