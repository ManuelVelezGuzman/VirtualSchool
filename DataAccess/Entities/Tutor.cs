using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Tutor
    {

        public Tutor()
        {
            Courses = new List<Course>();

        }


        public int Id { get; set; }
        public String Name { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }

        public Enums.Gender Gender { get; set; }


        public ICollection<Course> Courses;


    }



}
