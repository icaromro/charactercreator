using System;
using System.Collections.Generic;
using CharCreator.Domain.Entity;
using CharCreator.Domain.Interface.Repository;

namespace CharCreator.Data.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public void Add(User obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(User obj)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(long id)
        {
            throw new NotImplementedException();
        }

        public bool LogIn(User user)
        {
            
            throw new NotImplementedException();
        }

        public void Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
