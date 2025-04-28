using System;
using System.Collections.Generic;

namespace FUUniversity.models
{
    public partial class LopHoc
    {
        public LopHoc()
        {
            MaSinhViens = new HashSet<SinhVien>();
        }

        public int MaLop { get; set; }
        public int MaMonHoc { get; set; }
        public int MaGiangVien { get; set; }

        public virtual GiangVien MaGiangVienNavigation { get; set; } = null!;
        public virtual MonHoc MaMonHocNavigation { get; set; } = null!;

        public virtual ICollection<SinhVien> MaSinhViens { get; set; }
    }
}
