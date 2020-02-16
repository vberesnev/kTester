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
        public string Title { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public int QuestionsQuantity { get; set; }

        public List<Question> Questions;

        public Test() { }
        public Test(int id, string title, int subjectId, string subjectName, int professorId, string professorName, int questionsQuantity)
        {
            Id = id;
            Title = title;
            SubjectId = subjectId;
            Subject = new Subject(subjectId, subjectName);
            ProfessorId = professorId;
            Professor = new Professor(professorId, professorName);
            QuestionsQuantity = questionsQuantity;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
