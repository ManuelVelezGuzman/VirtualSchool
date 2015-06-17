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
    public class StudentMapper : EntityTypeConfiguration<Student>
    {
        public StudentMapper()
        {

            this.ToTable("Students");

            this.HasKey(c => c.Id);
            this.Property(c => c.Id).IsRequired();
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(s => s.Email).IsRequired();
            this.Property(s => s.Email).HasMaxLength(255);
            this.Property(s => s.Email).IsUnicode(false);

            this.Property(s => s.FirstName).IsRequired();
            this.Property(s => s.FirstName).HasMaxLength(50);

            this.Property(s => s.LastName).IsRequired();
            this.Property(s => s.LastName).HasMaxLength(50);

            this.Property(s => s.Gender).IsOptional();

            this.Property(s => s.DateOfBirth).IsRequired();
            this.Property(s => s.DateOfBirth).HasColumnType("smalldatetime");

            this.Property(s => s.RegistrationDate).IsOptional();
            this.Property(s => s.RegistrationDate).HasColumnType("smalldatetime");

            this.Property(s => s.LastLoginDate).IsOptional();
            this.Property(s => s.LastLoginDate).HasColumnType("smalldatetime");


        }
    }
}
