

using EFCoreConsoleApp;
using EFCoreConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using (HelloappContext db = new HelloappContext())
{
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();

    Company company1 = new Company { Name = "Google" };
    Company company2 = new Company { Name = "Microsoft" };

    User user1 = new User { Name = "Tom", Company = company1 };
    User user2 = new User { Name = "Bob", Company = company2 };
    User user3 = new User { Name = "Sam", Company = company2 };

    db.Companies.AddRange(company1, company2);
    db.Users.AddRange(user1, user2, user3);

    db.SaveChanges();  

}

using (HelloappContext db = new HelloappContext())
{
    foreach (var user in db.Users               
                                .Include(u => u.Company)
                                .ToList())
    {
        Console.WriteLine($"{user.Name} work in {user.Company?.Name}");
    }
}

Console.ReadLine();
