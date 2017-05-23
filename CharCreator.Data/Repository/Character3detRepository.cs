using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CharCreator.Data.Interface.Repository;
using CharCreator.Model.Entity;

namespace CharCreator.Data.Repository
{
    public class Character3detRepository: BaseRepository<Character3detRepository>, ICharacter3detRepository
    {
        public void Add(Character3det obj, DbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Character3det obj, DbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public void Delete(Character3det obj, DbTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public List<Character3det> GetAll()
        {
            throw new NotImplementedException();
        }

        public Character3det GetById(long id)
        {
            Character3det character = new Character3det();            
            string sql = @"SELECT character_id,scale_id,character_points,max_helth,max_mana,current_helth,current_mana,
		                        user_id,system_id,name,experience,background,sex,register_date
                          FROM [dbo].[3det_character] c3det
                          INNER JOIN character c ON c.id = c3det.character_id
                          WHERE c3det.character_id = @character_id";
            Hashtable parametros = new Hashtable();
            parametros["@character_id"] = id;

            DataTable dataTableCharacter = ObterDataTable(sql, parametros);
            if (dataTableCharacter.Rows.Count > 0)            
                character.Load3detCharacter(dataTableCharacter);            
            
            return character;
        }
    }
}
