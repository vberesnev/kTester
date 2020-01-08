using kTesterLib.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kTesterLib.StudentTesting
{
    /// <summary>
    /// Класс ответов на тест студента
    /// </summary>
    public class StudentAnswer
    {
        public int Id { get; set; }
        public int StudentTestId { get; set; }
        public StudentTest StudentTest { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public int AnswerId { get; set; }
        public Answer Answer { get; set; }
    }
}
