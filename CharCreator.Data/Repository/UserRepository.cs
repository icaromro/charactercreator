﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using CharCreator.Model.Entity;
using CharCreator.Data.Interface.Repository;

namespace CharCreator.Data.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public void Add(User obj, DbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public void Delete(User obj, DbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(long id)
        {
            string sql = @"SELECT * FROM [user] 
                            WHERE id = @id";
            Hashtable parametros = new Hashtable();
            parametros["@id"] = id;            

            DataTable dataTableUser = ObterDataTable(sql, parametros);
            if (dataTableUser.Rows.Count > 0)
            {
                User user = new User();
                user.LoadUser(dataTableUser);
                return user;
            }
            else
                return new User();
        }

        public bool LogIn(ref User user)
        {
            string sql = @"SELECT id, login, name, sex, birth_date, email, register_date FROM [user] 
                            WHERE login = @login AND password = @password";
            Hashtable parametros = new Hashtable();
            parametros["@login"] = user.login;
            parametros["@password"] = user.password;

            DataTable dataTableUser = ObterDataTable(sql, parametros);
            if (dataTableUser.Rows.Count > 0)
            {
                user.LoadUser(dataTableUser);
                return true;
            }
            else
                return false;
        }

        public void Update(User obj, DbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }
    }
}
