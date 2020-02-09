using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kTesterLib.Meta
{
    /// <summary>
    /// Класс факультета
    /// </summary>
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<StudyGroup> StudyGroups;

        public Faculty() { }

        public Faculty(int id, string name)
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
