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
        public string Name { get; set; }
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
        public int MenQuantity { get; set; }

        public StudyGroup()
        {
        }

        public StudyGroup(int id, string name, int facultyId, int quality)
        {
            Id = id;
            Name = name;
            FacultyId = facultyId;
            MenQuantity = quality;
        }
    }
}
