using FUUniversity.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUUniversity.repository
{
    public interface IGiangVienRepository
    {
        IEnumerable<GiangVien> GetAll();
        GiangVien GetById(int id);
        void Add(GiangVien giangVien);
        void Update(GiangVien giangVien);
        void Delete(int id);
    }
}
