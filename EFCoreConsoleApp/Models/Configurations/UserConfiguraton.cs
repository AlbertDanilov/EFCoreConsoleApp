using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreConsoleApp.Models.Configurations
{
    public class UserConfiguraton : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //modelBuilder.Entity<User>().ToTable("Peoples");
            //modelBuilder.Ignore<User>();
            //modelBuilder.Entity<User>().HasKey(x => x.Id);
            //modelBuilder.Entity<User>().HasKey(x => new {x.Id, x.Name});
            //modelBuilder.Entity<User>().Ignore(x => x.Age);
            //modelBuilder.Entity<User>().Property(x => x.Name).IsRequired();
            //modelBuilder.Entity<User>().Property(x => x.Name).IsOptional();
            builder.Property(x => x.Name).HasMaxLength(255);
        }
    }
}
