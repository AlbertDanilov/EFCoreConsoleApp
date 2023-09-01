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

    //вставка при создании таблицы
    //    modelBuilder.Entity<User>().HasData(new User { Id = 1, Name = "Albert", Age = 28 });

    //    base.OnModelCreating(modelBuilder);
    //}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasOne(u => u.Company)
            .WithMany(u => u.Users)
            .HasForeignKey(u => u.CompanyInfoKey)
            .OnDelete(DeleteBehavior.Cascade); //каскадное удаление


        base.OnModelCreating(modelBuilder);
    }

}
