using System;
using System.Collections.Generic;

namespace FUUniversity.models
{
    public partial class Diem
    {
        public int MaDiem { get; set; }
        public int MaSinhVien { get; set; }
        public int MaMonHoc { get; set; }
        public decimal? DiemGiuaKy { get; set; }
        public decimal? DiemThi { get; set; }
        public decimal? DiemTrungBinh { get; set; }

        public virtual MonHoc MaMonHocNavigation { get; set; } = null!;
        public virtual SinhVien MaSinhVienNavigation { get; set; } = null!;
    }
}
