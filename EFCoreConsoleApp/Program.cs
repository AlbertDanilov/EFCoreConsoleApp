
//Scaffold-DbContext "Data Source=D:\\VSprojects\\EFCoreConsoleApp\\EFCoreConsoleApp\\EFCoreConsoleApp\\DB\\helloapp.db" Microsoft.EntityFrameworkCore.Sqlite

using EFCoreConsoleApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json");
var config = builder.Build();

string connectionString = config.GetConnectionString("DefaultConnection");

var optionsBuilder = new DbContextOptionsBuilder<HelloappContext>();
var options = optionsBuilder.UseSqlite(connectionString).Options;

using (HelloappContext db = new HelloappContext(options))
{
    bool isDbAvalaible = db.Database.CanConnect();

    if (isDbAvalaible)
    {
        //User tom = new User { Name = "Tom", Age = 21};
        //User alice = new User { Name = "Alice", Age = 22};

        //await db.Users.AddRangeAsync(tom, alice);
        //await db.SaveChangesAsync();

        Console.WriteLine(123);
    }    
}

Console.ReadLine();
