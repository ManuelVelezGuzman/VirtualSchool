using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mappers
{
    public class EnrollmentMapper : EntityTypeConfiguration<Enrollment>
    {
        public EnrollmentMapper(){

            this.ToTable("Enrollments");

            this.HasKey(c => c.Id);
            this.Property(c => c.Id).IsRequired();
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.EnrollmentDate).IsRequired();
            this.Property(c => c.EnrollmentDate).HasColumnType("smalldatetime");


            this.HasOptional(c => c.Student).WithMany(c => c.Enrollments).Map(s => s.MapKey("StudentID")).WillCascadeOnDelete(false);
            this.HasOptional(c => c.Course).WithMany(c => c.Enrollments).Map(e => e.MapKey("CourseID")).WillCascadeOnDelete(false);
        }
    }
}
