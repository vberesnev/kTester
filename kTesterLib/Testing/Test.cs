using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kTesterLib.Meta;

namespace kTesterLib.Testing
{
    /// <summary>
    /// Класс теста
    /// </summary>
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public int QuestionsCount { get; set; }

        public List<Question> Questions;
    }
}
