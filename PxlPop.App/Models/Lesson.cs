using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PxlPop.App.Models
{
    public class Lesson
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Lecturers { get; set; }
        public string ImageUrl { get; set; }
        public DateTime Begin { get; set; }
        public TimeSpan Duration { get; set; }
        public string Department { get; set; }
    }

    public class  LessonGroup : List<Lesson>
    {
        public string Day { get; private set; }

        public LessonGroup(string day, List<Lesson> lessons) : base(lessons)
        {
            Day = day;
        }
    }
}
