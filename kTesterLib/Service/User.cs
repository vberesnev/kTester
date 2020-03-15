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
        public int Id { get;  private set; }
        public string Login { get;  private set; }
        //public string Password { get; private set; }
        public UserRights UserRights { get; private set; }
        public string Name { get; private set; }

        
        public User() { }
        public User(string login)
        {
            Login = login;
        }

        public User(int id, string login)
        {
            Id = id;
            Login = login;
        }

        public User(int id, string login, int rights, string name)
        {
            Id = id;
            Login = login;
            UserRights = (UserRights)rights;
            Name = name;
        }
        
        public override string ToString()
        {
            return Login;
        }
    }
}
