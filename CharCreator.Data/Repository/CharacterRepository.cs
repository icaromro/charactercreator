using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using CharCreator.Data.Interface.Repository;
using CharCreator.Model.Entity;

namespace CharCreator.Data.Repository
{
    public class CharacterRepository : BaseRepository<Character>, ICharacterRepository
    {
        public void Add(Character obj, DbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public void Delete(Character obj, DbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public List<Character> GetAll()
        {
            throw new NotImplementedException();
        }

        public Character GetById(long id)
        {
            Character character = new Character();            
            string sql = @"SELECT * FROM character 
                            WHERE id = @id";
            Hashtable parametros = new Hashtable();
            parametros["@id"] = id;

            DataTable dataTableCharacter = ObterDataTable(sql, parametros);
            if (dataTableCharacter.Rows.Count > 0)
            {
                character.LoadCharacter(dataTableCharacter);
                return character;
            }
            else
                return character;
        }

        public DataTable GetUserCharacters(long userId)
        {
            string sql = @"SELECT c.id, s.name as system_name, c.[name], register_date      
                          FROM [dbo].[character] c
                          INNER JOIN dbo.system s ON s.id = c.system_id
                          WHERE user_id = @user_id";
            Hashtable parametros = new Hashtable();
            parametros["@user_id"] = userId;            

            DataTable dataTableUserCharacters = ObterDataTable(sql, parametros);
            if (dataTableUserCharacters.Rows.Count > 0)                            
                return dataTableUserCharacters;            
            else
                return new DataTable();
        }

        public bool VerifyCharacterOwnership(long userId, long characterId)
        {
            string sql = @"SELECT 1 FROM [dbo].[character]                           
                          WHERE user_id = @user_id AND id = @id";
            Hashtable parametros = new Hashtable();
            parametros["@user_id"] = userId;
            parametros["@id"] = characterId;

            DataTable dataTableUserCharacters = ObterDataTable(sql, parametros);
            return dataTableUserCharacters.Rows.Count > 0;
                
        }

        public void Update(Character obj, DbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }
    }
}
