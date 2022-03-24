using System;
using System.Collections.Generic;
using System.Linq;
using Digital_Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Digital_Library.Repositories
{
    class BookRepository
    {
        public List<Book> GetAllBooksOrderByYear(AppContext db, bool descending = false)
        {
            var books = db.Books.Include(g => g.Genre).Include(a => a.Author);

            if (descending)
                return books.OrderByDescending(n => n.DateRelease.Year).ToList();
            else
                return books.OrderBy(n => n.DateRelease.Year).ToList();
        }

            public List<Book> GetAllBooksOrderByName(AppContext db, bool descending = false)
        {
            var books = db.Books.Include(g => g.Genre).Include(a => a.Author);

            if (descending)
                return books.OrderByDescending(n => n.Name).ToList();
            else
                return books.OrderBy(n => n.Name).ToList();
        }

        public Book GetLastBookByYear(AppContext db)
        {
            int maxYear = db.Books.Max(y => y.DateRelease.Year);
            return db.Books.Where(y => y.DateRelease.Year == maxYear).ToList()[0];
        }

        public int GetCountReadableBooksByUserId(int userId, AppContext db)
        {
            return db.Users.Where(u => u.Id == userId).Include(b => b.Books).ToList()[0].Books.Count;
        }

        public int GetCountBooksByGenre(string genre, AppContext db)
        {
            return db.Books.Where(a => a.Genre.Name == genre).Count();
        }
        
        public int GetCountAuthorBooksByName(string authorName, string authorSurname, AppContext db)
        {
            return db.Books.Where(a => a.Author.Name == authorName && a.Author.Surname == authorSurname).Count();
        }
        
        public bool IsThereReadableBookByUserId(int userId, string nameBook, AppContext db)
        {
            return db.Users.Where(u => u.Id == userId).Include(b => b.Books)
                    .Select(b => b.Books).ToList()[0]
                    .Where(n => n.Name == nameBook).Any();
        }

        public bool IsThereBookByAuthorAndTitle(string authorName, string authorSurname, string bookName, AppContext db)
        {
            return db.Books.Where(b => b.Author.Name == authorName &&
                    b.Author.Surname == authorSurname &&
                    b.Name == bookName).ToList().Any();
        }

        public List<string> GetBooksByGenreAndRangeYears(string genre, int startYear, int endYear, AppContext db)
        {
            int tmp;

            if (startYear > endYear)
            {
                tmp = startYear;
                startYear = endYear;
                endYear = tmp;
            }
                       
            return db.Books.Where(g => g.Genre.Name == genre)
                    .Where(d => d.DateRelease.Year >= startYear && d.DateRelease.Year <= endYear)
                    .Select(b => b.Name).ToList();
        }

        public  Book SelectBookById(int bookId, AppContext db)
        {
            return db.Books.FirstOrDefault(book => book.Id == bookId);
        }

        public List<Book> SelectAllBooks(AppContext db)
        {
            return db.Books.ToList();
        }

        public void AddBook(Book book, AppContext db)
        {
            db.Books.Add(book);
            db.SaveChanges();
        }

        public void RemoveBook(Book book, AppContext db)
        {
            db.Books.Remove(book);
            db.SaveChanges();
        }

        public void UpdateBookReleaseDateById(int bookId, DateTime newDate, AppContext db)
        {
            var book = db.Books.FirstOrDefault(book => book.Id == bookId);
            book.DateRelease = newDate;
            db.SaveChanges();
        }

    }
}
