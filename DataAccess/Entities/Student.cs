using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Student
    {
        public Student()
        {
            Enrollments = new List<Enrollment>();
        }

        public int Id { get; set; }
        public String Name { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public Enums.Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? RegistrationDate{ get; set; }
        public DateTime? LastLoginDate { get; set; }

        public ApplicationUser User { get; set; }

        public ICollection<Enrollment> Enrollments {get; set;}

    }
}
