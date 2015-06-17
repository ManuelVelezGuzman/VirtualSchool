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
    public class CourseMapper : EntityTypeConfiguration<Course>
    {
        public CourseMapper()
        {

            this.ToTable("Courses");
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.Id).IsRequired();

            this.Property(c => c.Name).HasMaxLength(255);
            this.Property(c => c.Name).IsRequired();


            this.Property(c => c.Description).IsRequired();

            this.Property(c => c.Description).IsRequired();
            this.Property(c => c.Description).HasMaxLength(1000);

            this.HasRequired(c => c.CourseSubject).WithMany().Map(s => s.MapKey("SubjectID"));
            this.HasRequired(c => c.CourseTutor).WithMany().Map(s => s.MapKey("TutorID"));

        }
    }
}
