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

        public static User[] GetByPage(ushort page = 0)
            => MDB.Get().Connection()
                .Query<User>("select * from users OFFSET @offset LIMIT 50", new {offset = page * 50}).ToArray();

        public static User Find(int id)
            => MDB.Get().Connection().Query<User>(
                "SELECT * FROM users WHERE id = @id LIMIT 1",
                new {id}
            ).FirstOrDefault();
        
        public static User FindByLogin(string login)
            => MDB.Get().Connection().Query<User>(
                "SELECT * FROM users WHERE login = @login LIMIT 1", new {login}
            ).FirstOrDefault();
        
        public static User FindByEmail(string email)
            => MDB.Get().Connection().Query<User>(
                "SELECT * FROM users WHERE email = @email LIMIT 1", new {email}
            ).FirstOrDefault();
        
        public static void Create(string login, string password, string email)
            => MDB.Get().Connection()
                .Execute(
                    "INSERT INTO public.users(login, password, email) VALUES (@login, @password, @email)"
                    , new {login, password, email}
                );

        public void Create() => Create(login, password, email);

        public User CreateAndGet() {
            Create();
            return FindByLogin(login);
        }

        public void Save()
            => MDB.Get().Connection()
                .Execute(
                    "UPDATE users SET login = @login, password = @password, email = @email WHERE id = @id",
                    new {login, password, email, id}
                );

        public User Refresh() => Find(id);
    }
}