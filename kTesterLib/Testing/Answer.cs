using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kTesterLib.Testing
{
    /// <summary>
    /// Класс ответа на вопрос теста
    /// </summary>
    public class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public string Text { get; set; }
        public bool IsTrue { get; set; }
    }
}
