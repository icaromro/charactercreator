using System;
using System.Data;

namespace CharCreator.Model.Entity
{
    public class User
    {
        public long id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public char sex { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }
        public DateTime registerDate { get; set; }

        public void LoadUser(DataTable dataTableUser)
        {
            DataRow dataRowUser = dataTableUser.Rows[0];
            this.id = Convert.ToInt64(dataRowUser["id"]);
            this.login = dataRowUser["login"].ToString();
            this.name = dataRowUser["name"].ToString();
            this.sex = Convert.ToChar(dataRowUser["sex"]);
            this.email = dataRowUser["email"].ToString();
            this.birthDate = Convert.ToDateTime(dataRowUser["birth_date"]);
            this.registerDate = Convert.ToDateTime(dataRowUser["register_date"]);
        }
    }
}
