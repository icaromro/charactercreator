using System.Data;
using CharCreator.Model.Entity;

namespace CharCreator.Data.Interface.Repository
{
    interface ICharacterRepository : IBaseRepository<Character>
    {
        DataTable GetUserCharacters(long userId);
        bool VerifyCharacterOwnership(long userId, long characterId);
    }
}
