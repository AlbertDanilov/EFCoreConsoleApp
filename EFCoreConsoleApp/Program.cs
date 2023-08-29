

using EFCoreConsoleApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using (HelloappContext db = new HelloappContext())
{
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    User tom = new User { Name = "Tom", Age = 21 };
    User alice = new User { Name = "Alice", Age = 22 };

    db.Users.AddRange(tom, alice);

    db.SaveChanges();

    var users = db.Users.ToList();
    Console.WriteLine("Users:");

    foreach (var user in users)
    {
        Console.WriteLine($"{user.Id}.{user.Name} - {user.Age}");
    }
}

Console.ReadLine();
