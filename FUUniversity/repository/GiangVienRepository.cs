using FUUniversity.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUUniversity.repository
{
    public  class GiangVienRepository : IGiangVienRepository
    {
        private readonly FPTUniversityDBContext _context;

        public GiangVienRepository(FPTUniversityDBContext context)
        {
            _context = context;
        }

        public IEnumerable<GiangVien> GetAll() => _context.GiangViens.ToList();

        public GiangVien GetById(int id) => _context.GiangViens.Find(id);

        public void Add(GiangVien giangVien)
        {
            _context.GiangViens.Add(giangVien);
            _context.SaveChanges();
        }

        public void Update(GiangVien giangVien)
        {
            _context.GiangViens.Update(giangVien);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var giangVien = _context.GiangViens.Find(id);
            if (giangVien != null)
            {
                _context.GiangViens.Remove(giangVien);
                _context.SaveChanges();
            }
        }
    }
}
