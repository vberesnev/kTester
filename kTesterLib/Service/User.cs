using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kTesterLib.Service
{
    /// <summary>
    /// Класс пользователя системы, нужен для авторизации в системе, разграничения прав и логгирования действий пользователя
    /// </summary>
    public class User
    {
        public int Id { get;  set; }
        public string Login { get;  set; }
        public string Password { get; private set; }
        public UserRights UserRights { get; private set; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public User(int id, string login)
        {
            Id = id;
            Login = login;
        }

        public User(int id, string login, string password, int rights)
        {
            Id = id;
            Login = login;
            Password = password;
            UserRights = (UserRights)rights;
        }

        public User() { }

        public override string ToString()
        {
            return Login;
        }
    }
}
