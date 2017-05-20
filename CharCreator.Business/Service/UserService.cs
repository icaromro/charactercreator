using CharCreator.Business.Interface.Service;
using CharCreator.Model.Entity;
using System.Collections.Generic;
using CharCreator.Data.Repository;

namespace CharCreator.Business.Service
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository() ;
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

        public bool LogIn(ref User user)
        {
            return _userRepository.LogIn(ref user);
        }
    }
}
