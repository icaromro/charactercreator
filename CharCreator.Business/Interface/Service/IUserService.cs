using CharCreator.Model.Entity;

namespace CharCreator.Business.Interface.Service
{
    public interface IUserService : IBaseService<User>
    {
        bool LogIn(ref User user);
    }
}
