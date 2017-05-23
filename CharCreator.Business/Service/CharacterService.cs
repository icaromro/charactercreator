using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using CharCreator.Business.Interface.Service;
using CharCreator.Data.Repository;
using CharCreator.Model.Entity;

namespace CharCreator.Business.Service
{
    public class CharacterService : ICharacterService
    {
        private readonly CharacterRepository _characterRepository;

        public CharacterService()
        {
            _characterRepository = new CharacterRepository();            
        }

        public void Add(Character obj, DbTransaction transaction = null)
        {
            _characterRepository.Add(obj, transaction);
        }

        public void Update(Character obj, DbTransaction transaction = null)
        {
            _characterRepository.Update(obj, transaction);
        }

        public void Delete(Character obj, DbTransaction transaction = null)
        {
            _characterRepository.Delete(obj, transaction);
        }

        public List<Character> GetAll()
        {
            return _characterRepository.GetAll();
        }

        public Character GetById(long id)
        {
            return _characterRepository.GetById(id);
        }

        public DataTable GetUserCharacters(long userId)
        {
            return _characterRepository.GetUserCharacters(userId);
        }

        public bool VerifyCharacterOwnership(long userId, long characterId)
        {
            return _characterRepository.VerifyCharacterOwnership(userId, characterId);
        }
    }
}
