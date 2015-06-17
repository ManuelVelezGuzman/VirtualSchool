using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Subject
    {
        public Subject()
        {
            Courses = new List<Course>();
        }
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public ICollection<Course> Courses {get;set;}

    }
}
