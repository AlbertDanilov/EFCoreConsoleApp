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
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=D:\\\\\\\\VSprojects\\\\\\\\EFCoreConsoleApp\\\\\\\\EFCoreConsoleApp\\\\\\\\EFCoreConsoleApp\\\\\\\\DB\\\\\\\\helloapp.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
