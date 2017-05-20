using CharCreator.Model.Entity;

namespace CharCreator.Data.Interface.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        bool LogIn(ref User user);
    }
}
