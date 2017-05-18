using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
            string sql = @"SELECT id, login, name, sex, birth_date, email, register_date FROM [user] 
                            WHERE login = @login AND password = @password";
            Hashtable parametros = new Hashtable();
            parametros["@login"] = user.login;
            parametros["@password"] = user.password;

            DataTable dataTableUser = ObterDataTable(sql, parametros);
            if(ExecuteQuery(sql, parametros))
                return true;
            else
                return false;                                   
        }

        public void Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
