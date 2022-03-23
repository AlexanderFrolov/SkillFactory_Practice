using System;
using System.Collections.Generic;
using System.Linq;
using Digital_Library.Models;

namespace Digital_Library.Repositories
{
    static class UserRepository
    {
        public static User SelectUserById(int userId, AppContext db)
        {
            return db.Users.FirstOrDefault(user => user.Id == userId);
        }

        public static List<User> SelectAllUsers(AppContext db)
        {
            return db.Users.ToList();
        }

        public static void AddUser(User user, AppContext db) 
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static void RemoveUser(User user, AppContext db)
        {
            db.Users.Remove(user);
            db.SaveChanges();
        }

        public static void UpdateUserNameById(int userId, string newName, AppContext db)
        {
            var user = db.Users.FirstOrDefault(user => user.Id == userId);
            user.Name = newName;
            db.SaveChanges();
        }
    }
}
