using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFCoreConsoleApp;

public partial class HelloappContext : DbContext
{
    public HelloappContext()
    {
        Database.EnsureCreated();
    }

    public HelloappContext(DbContextOptions<HelloappContext> options)
        : base(options)
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite();
        //optionsBuilder.LogTo(Console.WriteLine);
        optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
