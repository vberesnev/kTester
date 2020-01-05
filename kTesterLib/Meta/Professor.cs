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
        public int UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
    }
}
