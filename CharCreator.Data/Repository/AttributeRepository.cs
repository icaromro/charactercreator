using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using CharCreator.Data.Interface.Repository;
using CharCreator.Model.Entity;

namespace CharCreator.Data.Repository
{
    public class AttributeRepository : BaseRepository<CharacterAttribute>, IAttributeRepository
    {
        public void Add(CharacterAttribute obj, DbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public void Delete(CharacterAttribute obj, DbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public List<CharacterAttribute> GetAll()
        {
            throw new NotImplementedException();
        }

        public CharacterAttribute GetById(long id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetBySystemId(short systemId)
        {
            string sql = @"SELECT id, name, description, 0 as value, 0 as bonus FROM [dbo].[attribute]                          
                          WHERE system_id = @system_id";
            Hashtable parametros = new Hashtable();
            parametros["@system_id"] = systemId;

            DataTable dataTableAttributes = ObterDataTable(sql, parametros);
            if (dataTableAttributes.Rows.Count > 0)
                return dataTableAttributes;
            else
                return new DataTable();
        }

        public void Update(CharacterAttribute obj, DbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }
    }
}
