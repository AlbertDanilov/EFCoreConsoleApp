
//Scaffold-DbContext "Data Source=D:\\VSprojects\\EFCoreConsoleApp\\EFCoreConsoleApp\\EFCoreConsoleApp\\DB\\helloapp.db" Microsoft.EntityFrameworkCore.Sqlite

using EFCoreConsoleApp;

using (HelloappContext db = new HelloappContext())
{
    bool isDbAvalaible = db.Database.CanConnect();

    if (isDbAvalaible)
    {
        var user = db.Users.FirstOrDefault();

        //if (user != null)
        //{
        //    user.Name = "Albert";
        //    user.Age = 28;
        //    db.SaveChanges();
        //}

        //user = db.Users.OrderBy((x) => x.Id).LastOrDefault();
        //db.Users.Remove(user);
        //db.SaveChanges();


    }    
}

Console.ReadLine();
