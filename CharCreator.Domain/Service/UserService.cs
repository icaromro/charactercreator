using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharCreator.Domain.Entity;
using CharCreator.Domain.Interface.Repository;
using CharCreator.Domain.Interface.Service;

namespace CharCreator.Domain.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Add(User obj)
        {
            _userRepository.Add(obj);
        }

        public void Update(User obj)
        {
            _userRepository.Update(obj);
        }

        public void Delete(User obj)
        {
            _userRepository.Delete(obj);
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(long id)
        {
            return _userRepository.GetById(id);
        }

        public bool LogIn(User user)
        {
            return _userRepository.LogIn(user);
        }
    }
}
