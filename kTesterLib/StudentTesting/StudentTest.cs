using kTesterLib.Meta;
using kTesterLib.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kTesterLib.StudentTesting
{
    /// <summary>
    /// Класс тестирования студента 
    /// </summary>
    public class StudentTest
    {
        public int Id { get; set; }
        public int StudyGroupId { get; set; }
        public StudyGroup StudyGroup { get; set; }
        public int TestId { get; set; }
        public Test Test { get; set; }
        public string InviteString { get; set; }
        public string StudentName { get; set; }
    }
}
