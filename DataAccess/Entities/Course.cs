using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Course
    {
        public Course()
        {
            Enrollments = new List<Enrollment>();
            CourseTutor = new Tutor();
            CourseSubject = new Subject();
        }

        public int Id { get; set; }
        public String Name { get; set; }
        public Double Duration { get; set; }
        public String Description { get; set; }

        public Tutor CourseTutor { get; set; }
        public Subject CourseSubject { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }


    }
}
