

using System;

namespace CharCreator.Domain.Entity
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


    }
}
