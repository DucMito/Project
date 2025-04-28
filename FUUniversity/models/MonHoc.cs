using System;
using System.Collections.Generic;

namespace FUUniversity.models
{
    public partial class MonHoc
    {
        public MonHoc()
        {
            DangKyMonHocs = new HashSet<DangKyMonHoc>();
            Diems = new HashSet<Diem>();
            LopHocs = new HashSet<LopHoc>();
            MaGiangViens = new HashSet<GiangVien>();
        }

        public int MaMonHoc { get; set; }
        public string TenMonHoc { get; set; } = null!;
        public int SoTinChi { get; set; }
        public string ChuyenNganh { get; set; } = null!;

        public virtual ICollection<DangKyMonHoc> DangKyMonHocs { get; set; }
        public virtual ICollection<Diem> Diems { get; set; }
        public virtual ICollection<LopHoc> LopHocs { get; set; }

        public virtual ICollection<GiangVien> MaGiangViens { get; set; }
    }
}
