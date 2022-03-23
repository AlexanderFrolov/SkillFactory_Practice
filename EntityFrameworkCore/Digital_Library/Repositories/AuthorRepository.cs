using System;
using System.Collections.Generic;
using System.Linq;
using Digital_Library.Models;


namespace Digital_Library.Repositories
{
    class AuthorRepository
    {
        public Author SelectAuthorById(int authorId, AppContext db)
        {
            return db.Authors.FirstOrDefault(author => author.Id == authorId);
        }

        public List<Author> SelectAllAuthors(AppContext db)
        {
            return db.Authors.ToList();
        }

        public void AddAuthor(Author author, AppContext db)
        {
            db.Authors.Add(author);
            db.SaveChanges();
        }

        public void RemoveAuthor(Author author, AppContext db)
        {
            db.Authors.Remove(author);
            db.SaveChanges();
        }
    }
}
