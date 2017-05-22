using System.Data;
using CharCreator.Model.Entity;

namespace CharCreator.Business.Interface.Service
{
    public interface ICharacterService : IBaseService<Character>
    {
        DataTable GetUserCharacters(long userId);
        bool VerifyCharacterOwnership(long userId, long characterId);
    }
}
