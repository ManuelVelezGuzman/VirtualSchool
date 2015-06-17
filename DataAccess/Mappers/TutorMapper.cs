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
    public class TutorMapper : EntityTypeConfiguration<Tutor>
    {
        public TutorMapper()
        {
            this.ToTable("Tutors");

            this.HasKey(c => c.Id);
            this.Property(c => c.Id).IsRequired();
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.Name).IsRequired();
            this.Property(c => c.Name).HasMaxLength(50);

            this.Property(c => c.FirstName).HasMaxLength(50);
            this.Property(c => c.FirstName).IsRequired();

            this.Property(c => c.LastName).HasMaxLength(50);
            this.Property(c => c.LastName).IsRequired();

            this.Property(c => c.Email).IsRequired();
            this.Property(c => c.Email).HasMaxLength(50);
            this.Property(c => c.Email).IsUnicode(false);

            this.Property(c => c.UserName).IsRequired();
            this.Property(c => c.UserName).HasMaxLength(50);
            this.Property(c => c.UserName).IsUnicode(false);


            this.Property(c => c.Password).IsRequired();
            this.Property(c => c.Password).HasMaxLength(255);
            this.Property(c => c.Password).IsUnicode(false);

            this.Property(c => c.Gender).IsOptional();

        }
    }
}
