using System;
using System.Collections.Generic;

namespace FUUniversity.models
{
    public partial class SinhVien
    {
        public SinhVien()
        {
            DangKyMonHocs = new HashSet<DangKyMonHoc>();
            Diems = new HashSet<Diem>();
            MaLops = new HashSet<LopHoc>();
        }

        public int MaSinhVien { get; set; }
        public string Ten { get; set; } = null!;
        public string Lop { get; set; } = null!;
        public string Khoa { get; set; } = null!;
        public decimal? DiemTrungBinh { get; set; }
        public int? SoLuongMonHoc { get; set; }

        public virtual ICollection<DangKyMonHoc> DangKyMonHocs { get; set; }
        public virtual ICollection<Diem> Diems { get; set; }

        public virtual ICollection<LopHoc> MaLops { get; set; }
    }
}
