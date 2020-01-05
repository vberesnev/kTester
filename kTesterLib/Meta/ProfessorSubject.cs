using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kTesterLib.Meta
{
    /// <summary>
    /// Класс сопоставления преподавателя и предмета, по которому он может проводить тестирование
    /// </summary>
    public class ProfessorSubject
    {
        public int Id { get; set; }
        public int ProfessorId { get; set; }
        public Professor Processor { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
