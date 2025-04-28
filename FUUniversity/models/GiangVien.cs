using System;
using System.Collections.Generic;

namespace FUUniversity.models
{
    public partial class GiangVien
    {
        public GiangVien()
        {
            LopHocs = new HashSet<LopHoc>();
            MaMonHocs = new HashSet<MonHoc>();
        }

        public int MaGiangVien { get; set; }
        public string Ten { get; set; } = null!;
        public string ChuyenNganh { get; set; } = null!;

        public virtual ICollection<LopHoc> LopHocs { get; set; }

        public virtual ICollection<MonHoc> MaMonHocs { get; set; }
    }
}
