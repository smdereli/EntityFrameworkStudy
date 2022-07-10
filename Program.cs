// See https://aka.ms/new-console-template for more information
using EntityFramework;

Console.WriteLine("Hello, World!");

using(var db = new ShopContext()){


    var user = db.Users.Where(x => x.Name == "Mert").FirstOrDefault();

    System.Console.WriteLine(user.Id);
    System.Console.WriteLine(user.Name);

    // db.Users.Add(new User{
    //     Name = "Mert",
    // });

    // db.SaveChanges();
}