

using EFCoreConsoleApp;
using EFCoreConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using (HelloappContext db = new HelloappContext())
{
    //User tom = new User { Name = "Tom", Age = 21 };
    //User alice = new User { Name = "Alice", Age = 22 };

    //db.Users.AddRange(tom, alice);

    //db.SaveChanges();

    //var users = db.Users.ToList();
    //Console.WriteLine("Users:");

    //foreach (var user in users)
    //{
    //    Console.WriteLine($"{user.Id}.{user.Name} - {user.Age}");
    //}



    Company company1 = new Company { Name = "Google" };
    Company company2 = new Company { Name = "Microsoft" };

    User user1 = new User { Name = "Tom", Company = company1 };
    User user2 = new User { Name = "Bob", Company = company2 };
    User user3 = new User { Name = "Sam", Company = company2 };

    db.Companies.AddRange(company1, company2);
    db.Users.AddRange(user1, user2, user3);

    db.SaveChanges();

    foreach (var user in db.Users.ToList()) 
    {
        Console.WriteLine($"{user.Name} work in {user.Company?.Name}");
    }

}

Console.ReadLine();
