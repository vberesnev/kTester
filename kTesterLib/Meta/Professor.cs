using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kTesterLib.Service;

namespace kTesterLib.Meta
{
    /// <summary>
    /// Класс преподавателя 
    /// </summary>
    public class Professor
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public Professor() { }

        public Professor(int id, string name, int userId, string userName)
        {
            Id = id;
            Name = name;
            UserId = userId;
            User = new User(userId, userName);
        }

        public Professor(int id, string name, int userId)
        {
            Id = id;
            Name = name;
            UserId = userId;
        }
        public Professor(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
