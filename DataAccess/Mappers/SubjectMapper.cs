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
    public class SubjectMapper : EntityTypeConfiguration<Subject>
    {
        public SubjectMapper()
        {
            this.ToTable("Subjects");
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).IsRequired();
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            this.Property(c => c.Name).HasMaxLength(100);
            this.Property(c => c.Name).IsRequired();
            this.Property(c => c.Description).HasMaxLength(255);

        }
    }
}
