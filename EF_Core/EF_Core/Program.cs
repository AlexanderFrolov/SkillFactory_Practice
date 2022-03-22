using System;

namespace EF_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppContext()) 
            {
                // использование EF
                var user1 = new User { Name = "Arthur", Role = "Admin" };
                var user2 = new User { Name = "Klim", Role = "User" };
                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
            }

        }
    }
}
