using FUUniversity.models;
using FUUniversity.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUUniversity.service
{
    public class SinhVienService
    {
        private readonly ISinhVienRepository _repository;

        public SinhVienService(ISinhVienRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<SinhVien> GetAll() => _repository.GetAll();

        public SinhVien GetById(int id) => _repository.GetById(id);

        public void Add(SinhVien sinhVien) => _repository.Add(sinhVien);

        public void Update(SinhVien sinhVien) => _repository.Update(sinhVien);

        public void Delete(int id) => _repository.Delete(id);
    }
}
