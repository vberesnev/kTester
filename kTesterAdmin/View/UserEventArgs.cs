using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kTesterAdmin.View
{
    public class UserEventArgs: EventArgs
    {
        public int UserId { get; private set; }
        public string UserName { get; private set; }

        public UserEventArgs(int id, string name)
        {
            UserId = id;
            UserName = name;
        }
    }
}
