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
        public string Password { get;  set; }
        public UserRights UserRights { get;  set; }
    }
}
