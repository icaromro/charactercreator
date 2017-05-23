using System;
using System.Data;

namespace CharCreator.Model.Entity
{
    public class Character3det
    {        
        public long character_id { get; set; }
        public Character character { get; set; }
        public int scale_id { get; set; }
        public int max_helth { get; set; }
        public int max_mana { get; set; }
        public int current_helth { get; set; }
        public int current_mana { get; set; }

        public void Load3detCharacter(DataTable dataTable3detCharacter)
        {
            DataRow dataRow3detCharacter = dataTable3detCharacter.Rows[0];
            Load3detCharacter(dataRow3detCharacter);
        }

        public void Load3detCharacter(DataRow dataRow3detCharacter)
        {            
            this.character.id = this.character_id = Convert.ToInt64(dataRow3detCharacter["character_id"]);
            this.scale_id = Convert.ToInt32(dataRow3detCharacter["scale_id"]);
            this.max_helth = Convert.ToInt32(dataRow3detCharacter["max_helth"]);
            this.max_mana = Convert.ToInt32(dataRow3detCharacter["max_mana"]);
            this.current_helth = Convert.ToInt32(dataRow3detCharacter["current_helth"]);
            this.current_mana = Convert.ToInt32(dataRow3detCharacter["current_mana"]);
            this.character.user_id = Convert.ToInt64(dataRow3detCharacter["user_id"]);
            this.character.system_id = Convert.ToInt16(dataRow3detCharacter["system_id"]);
            this.character.name = dataRow3detCharacter["name"].ToString();
            this.character.experiente = Convert.ToInt32(dataRow3detCharacter["experiente"]);
            this.character.background = dataRow3detCharacter["background"].ToString();
            this.character.sex = Convert.ToChar(dataRow3detCharacter["sex"]);
        }
    }
}
