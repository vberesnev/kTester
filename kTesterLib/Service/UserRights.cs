using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kTesterLib.Service
{
    /// <summary>
    /// Права пользователя 
    /// </summary>
    public enum UserRights
    {
        [Description("Администратор")]
        Administrator = 1,

        [Description("Профессор")]
        Professor = 2,

        [Description("Студент")]
        Student = 3
    }

}
