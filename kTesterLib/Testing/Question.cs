using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kTesterLib.Testing
{
    /// <summary>
    /// Класс вопроса на тест
    /// </summary>
    public class Question
    {
        public int Id { get; set; }
        public int TestId { get; set; }
        public Test Test { get; set; }
        public string Text { get; set; }
        public bool IsMultiselect { get; set; }

        public List<Answer> Answers;

    }
}
