
//Scaffold-DbContext "Data Source=D:\\VSprojects\\EFCoreConsoleApp\\EFCoreConsoleApp\\EFCoreConsoleApp\\DB\\helloapp.db" Microsoft.EntityFrameworkCore.Sqlite

using EFCoreConsoleApp;

using (HelloappContext db = new HelloappContext())
{
    bool isDbAvalaible = db.Database.CanConnect();

    if (isDbAvalaible)
    {
        User tom = new User { Name = "Tom", Age = 21};
        User alice = new User { Name = "Alice", Age = 22};

        await db.Users.AddRangeAsync(tom, alice);
        await db.SaveChangesAsync();

        Console.WriteLine(123);
    }    
}

Console.ReadLine();
