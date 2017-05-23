using CharCreator.Business.Interface.Service;
using CharCreator.Model.Entity;
using System.Collections.Generic;
using System.Data.Common;
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

        public void Add(User obj, DbTransaction transaction = null)
        {
            _userRepository.Add(obj, transaction);
        }

        public void Update(User obj, DbTransaction transaction = null)
        {
            _userRepository.Update(obj, transaction);
        }

        public void Delete(User obj, DbTransaction transaction = null)
        {
            _userRepository.Delete(obj, transaction);
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
