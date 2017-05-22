using System;
using System.Data;

namespace CharCreator.Model.Entity
{
    public class Character
    {
        public long id { get; set; }        
        public long user_id { get; set; }
        public short system_id { get; set; }
        public string name { get; set; }
        public int experiente { get; set; }
        public string background { get; set; }
        public char sex { get; set; }

        public void LoadCharacter(DataTable dataTableCharacter)
        {
            DataRow dataRowCharacter = dataTableCharacter.Rows[0];
            LoadCharacter(dataRowCharacter);                        
        }

        public void LoadCharacter(DataRow dataRowCharacter)
        {             
            this.id = Convert.ToInt64(dataRowCharacter["id"]);
            this.user_id = Convert.ToInt64(dataRowCharacter["user_id"]);
            this.system_id = Convert.ToInt16(dataRowCharacter["system_id"]);
            this.name = dataRowCharacter["name"].ToString();
            this.experiente = Convert.ToInt32(dataRowCharacter["experiente"]);
            this.background = dataRowCharacter["background"].ToString();
            this.sex = Convert.ToChar(dataRowCharacter["sex"]);
        }
    }
}
