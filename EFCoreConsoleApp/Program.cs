using EFCoreConsoleApp.DAL;
using EFCoreConsoleApp.Models;

using (ApplicationContext db = new ApplicationContext())
{
    User tom = new User { Name = "Tom", Age = 33 };
    User alice = new User { Name = "Alice", Age = 26 };

    db.Users.Add(tom);
    db.Users.Add(alice);
    db.SaveChanges();
    Console.WriteLine("Objects saved");

    var users = db.Users.ToList();
    Console.WriteLine("Users:");
    foreach (var user in users)
    {
        Console.WriteLine($"{user.Id}.{user.Name} - {user.Age}");
    }

    Console.ReadLine();
}