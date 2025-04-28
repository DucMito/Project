using FUUniversity.models;
using FUUniversity.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUUniversity.service
{
    public  class GiangVienService
    {
        private readonly IGiangVienRepository _repository;

        public GiangVienService(IGiangVienRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<GiangVien> GetAll() => _repository.GetAll();

        public GiangVien GetById(int id) => _repository.GetById(id);

        public void Add(GiangVien giangVien) => _repository.Add(giangVien);

        public void Update(GiangVien giangVien) => _repository.Update(giangVien);

        public void Delete(int id) => _repository.Delete(id);
    }
}
