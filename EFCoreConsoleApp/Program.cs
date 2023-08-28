
//Scaffold-DbContext "Data Source=D:\\VSprojects\\EFCoreConsoleApp\\EFCoreConsoleApp\\EFCoreConsoleApp\\DB\\helloapp.db" Microsoft.EntityFrameworkCore.Sqlite

using EFCoreConsoleApp;

using (HelloappContext db = new HelloappContext())
{
    bool isDbAvalaible = db.Database.CanConnect();

    if (isDbAvalaible)
    {
        var users = db.Users.ToList();

        Console.WriteLine("Users:");

        foreach (var u in users)
        {
            Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
        }
    }    
}

Console.ReadLine();
