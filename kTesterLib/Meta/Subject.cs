using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kTesterLib.Meta
{
    /// <summary>
    /// Класс учебных предметов
    /// </summary>
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Subject() { }

        public override string ToString()
        {
            return Name;
        }
    }
}
