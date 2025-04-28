using System;
using System.Collections.Generic;

namespace FUUniversity.models
{
    public partial class DangKyMonHoc
    {
        public int MaDangKy { get; set; }
        public int MaSinhVien { get; set; }
        public int MaMonHoc { get; set; }
        public DateTime? NgayDangKy { get; set; }

        public virtual MonHoc MaMonHocNavigation { get; set; } = null!;
        public virtual SinhVien MaSinhVienNavigation { get; set; } = null!;
    }
}
