using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

namespace EFCoreConsoleApp;

public partial class HelloappContext : DbContext
{    
    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<User>().ToTable("Peoples");
        //modelBuilder.Ignore<User>();
        //modelBuilder.Entity<User>().HasKey(x => x.Id);
        //modelBuilder.Entity<User>().HasKey(x => new {x.Id, x.Name});
        //modelBuilder.Entity<User>().Ignore(x => x.Age);
        //modelBuilder.Entity<User>().Property(x => x.Name).IsRequired();
        //modelBuilder.Entity<User>().Property(x => x.Name).IsOptional();
        //modelBuilder.Entity<User>().Property(x => x.Name).HasMaxLength(255);

        base.OnModelCreating(modelBuilder);
    }
}
