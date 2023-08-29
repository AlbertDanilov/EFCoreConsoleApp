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

    readonly StreamWriter logStream = new StreamWriter("mylog.txt", true);
    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite();
        //optionsBuilder.LogTo(Console.WriteLine);
        //optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message));
        optionsBuilder.LogTo(logStream.WriteLine);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    public override void Dispose()
    {
        base.Dispose();
        logStream.Dispose();
    }

    public override async ValueTask DisposeAsync()
    {
        await base.DisposeAsync();
        await logStream.DisposeAsync();
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
