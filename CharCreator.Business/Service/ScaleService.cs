using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharCreator.Business.Interface.Service;
using CharCreator.Data.Repository;
using CharCreator.Model.Entity;

namespace CharCreator.Business.Service
{
    public class ScaleService : BaseService<Scale>, IScaleService
    {
        private readonly ScaleRepository _scaleRepository;

        public ScaleService()
        {
            _scaleRepository = new ScaleRepository();
        }

        public void Add(Scale obj, DbTransaction transaction = null)
        {
            _scaleRepository.Add(obj,transaction);
        }

        public void Update(Scale obj, DbTransaction transaction = null)
        {
            _scaleRepository.Update(obj, transaction);
        }

        public void Delete(Scale obj, DbTransaction transaction = null)
        {
            _scaleRepository.Delete(obj, transaction);
        }

        public DataTable GetAllDataTable()
        {
            return _scaleRepository.GetAllDataTable();
        }

        public List<Scale> GetAll()
        {
            return _scaleRepository.GetAll();
        }

        public Scale GetById(long id)
        {
            return _scaleRepository.GetById(id);
        }
    }
}
