using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharCreator.Business.Interface.Service;
using CharCreator.Data.Repository;

namespace CharCreator.Business.Service
{
    public class SystemService : BaseService<Model.Entity.System>, ISystemService
    {
        private readonly SystemRepository _systemRepository;

        public SystemService()
        {
            _systemRepository = new SystemRepository();    
        }

        public void Add(Model.Entity.System obj, DbTransaction transaction = null)
        {
            _systemRepository.Add(obj, transaction);
        }

        public void Update(Model.Entity.System obj, DbTransaction transaction = null)
        {
            _systemRepository.Update(obj, transaction);
        }

        public void Delete(Model.Entity.System obj, DbTransaction transaction = null)
        {
            _systemRepository.Delete(obj, transaction);
        }

        public List<Model.Entity.System> GetAll()
        {
            return _systemRepository.GetAll();
        }

        public Model.Entity.System GetById(long id)
        {
            return _systemRepository.GetById(id);
        }

        public IEnumerable<Model.Entity.System> GetAllActive()
        {
            return _systemRepository.GetAll().Where(s => s.IsActive());
        }

        public DataTable GetAllActiveDataTable()
        {
            return _systemRepository.GetAllActive();
        }
    }
}
