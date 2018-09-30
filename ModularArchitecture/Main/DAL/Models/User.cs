using System;
using System.Linq;
using Dapper;
using Main.BLL.Modules.DB;

namespace Main.DAL.Models
{
    public class User
    {
        public int id;
        public string login;
        public string password;
        public string email;
        public DateTime register_date;

        public static User[] All()
            => MDB.Get().Connection().Query<User>("select * from users").ToArray();
    }
}