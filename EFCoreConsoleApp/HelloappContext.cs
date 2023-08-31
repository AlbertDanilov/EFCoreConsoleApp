using System;
using System.Collections.Generic;
using EFCoreConsoleApp.Models;
using EFCoreConsoleApp.Models.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

namespace EFCoreConsoleApp;

public partial class HelloappContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Company> Companies { get; set; } = null!;

    public HelloappContext() 
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();    
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
    }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.ApplyConfiguration(new UserConfiguraton());

    //    modelBuilder.Entity<User>().HasData(new User { Id = 1, Name = "Albert", Age = 28 });

    //    base.OnModelCreating(modelBuilder);
    //}
}
