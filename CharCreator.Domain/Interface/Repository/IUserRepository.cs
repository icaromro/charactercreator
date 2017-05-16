using CharCreator.Domain.Entity;

namespace CharCreator.Domain.Interface.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        bool LogIn(User user);
    }
}
