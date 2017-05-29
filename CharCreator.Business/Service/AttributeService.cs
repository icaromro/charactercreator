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
    public class AttributeService : BaseService<CharacterAttribute>, IAttributeService
    {
        private readonly AttributeRepository _attributeRepository;

        public AttributeService()
        {
            _attributeRepository = new AttributeRepository();
        }

        public void Add(CharacterAttribute obj, DbTransaction transaction = null)
        {
            _attributeRepository.Add(obj, transaction);
        }

        public void Delete(CharacterAttribute obj, DbTransaction transaction = null)
        {
            _attributeRepository.Delete(obj, transaction);
        }

        public List<CharacterAttribute> GetAll()
        {
            return _attributeRepository.GetAll();
        }

        public CharacterAttribute GetById(long id)
        {
            return _attributeRepository.GetById(id);
        }

        public DataTable GetBySystemId(short systemId)
        {
            return _attributeRepository.GetBySystemId(systemId);
        }

        public void Update(CharacterAttribute obj, DbTransaction transaction = null)
        {
            _attributeRepository.Update(obj, transaction);
        }
    }
}
