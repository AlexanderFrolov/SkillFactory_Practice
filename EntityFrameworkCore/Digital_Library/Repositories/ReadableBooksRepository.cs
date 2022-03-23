using System;
using System.Collections.Generic;
using System.Linq;
using Digital_Library.Models;


namespace Digital_Library.Repositories
{
    class ReadableBooksRepository
    {
        public void AddBookToReadableByUserId(Book book, int userId, AppContext db)
        {
            db.Users.FirstOrDefault(user => user.Id == userId).Books.Add(book);
            db.SaveChanges();     
        }

        public void AddBookToReadableByUserId(List<Book> books, int userId, AppContext db)
        {
            db.Users.FirstOrDefault(user => user.Id == userId).Books.AddRange(books);
            db.SaveChanges();  
        }

        public void RemoveBookFromReadableByUserId(Book book, int userId, AppContext db)
        {
            var user = db.Users.FirstOrDefault(user => user.Id == userId);

            if (user.Books.Contains(book))
            {
                user.Books.Remove(book);
            }

            db.SaveChanges();
        }
    }
}
