using FUUniversity.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUUniversity.repository
{
    public  class SinhVienRepository : ISinhVienRepository
    {
        private readonly FPTUniversityDBContext _context;

        public SinhVienRepository(FPTUniversityDBContext context)
        {
            _context = context;
        }

        public IEnumerable<SinhVien> GetAll() => _context.SinhViens.ToList();

        public SinhVien GetById(int id) => _context.SinhViens.Find(id);

        public void Add(SinhVien sinhvien)
        {
            _context.SinhViens.Add(sinhvien);
            _context.SaveChanges();
        }

        public void Update(SinhVien sinhvien)
        {
            _context.SinhViens.Update(sinhvien);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var sinhvien = _context.SinhViens.Find(id);
            if (sinhvien != null)
            {
                _context.SinhViens.Remove(sinhvien);
                _context.SaveChanges();
            }
        }
    }
}
