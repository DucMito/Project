using FUUniversity.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUUniversity.repository
{
    public interface ISinhVienRepository
    {
        IEnumerable<SinhVien> GetAll();
        SinhVien GetById(int id);
        void Add(SinhVien sinhVien);
        void Update(SinhVien sinhVien);
        void Delete(int id);
    }
}
