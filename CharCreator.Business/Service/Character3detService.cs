using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharCreator.Business.Interface.Service;
using CharCreator.Data.Repository;
using CharCreator.Model.Entity;

namespace CharCreator.Business.Service
{
    public class Character3detService : BaseService<Character3detService>, ICharacter3detService
    {
        private readonly Character3detRepository _character3DetRepository;

        public Character3detService()
        {
            _character3DetRepository = new Character3detRepository();
        }

        public void Add(Character3det obj, DbTransaction transaction = null)
        {
            _character3DetRepository.Add(obj, transaction);
        }

        public void Update(Character3det obj, DbTransaction transaction = null)
        {
            _character3DetRepository.Update(obj, transaction);
        }

        public void Delete(Character3det obj, DbTransaction transaction = null)
        {
            _character3DetRepository.Delete(obj, transaction);
        }

        public List<Character3det> GetAll()
        {
            return _character3DetRepository.GetAll();
        }

        public Character3det GetById(long id)
        {
            return _character3DetRepository.GetById(id);
        }
    }
}
