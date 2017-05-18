using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharCreator.Domain.Entity;

namespace CharCreator.Domain.Interface.Service
{
    public interface IUserService : IBaseService<User>
    {
        bool LogIn(User user);
    }
}
