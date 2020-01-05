using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kTesterLib.Meta
{
    /// <summary>
    /// Класс учебных групп
    /// </summary>
    public class StudyGroup
    {
        public int Id { get; set; }
        public int FucultyId { get; set; }
        public Faculty Faculty { get; set; }
        public string Name { get; set; }
    }
}
