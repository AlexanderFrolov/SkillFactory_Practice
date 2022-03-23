using System;
using System.Collections.Generic;
using System.Linq;
using Digital_Library.Models;
using Digital_Library.Repositories;


namespace Digital_Library
{
    class TestData
    {

        public static void EnterTestDataIntoDatabase() 
        {
            // Создаем контекст для добавления данных
            using (AppContext db = new AppContext())
            {
                // Пересоздаем базу
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                // Заполняем данными таблицу Users
                var user1 = new User
                {
                    Name = "Ivan",
                    Surname = "Ivanov",
                    Email = "ivanov555@mail.ru",
                    Login = "Ivan_Dark",
                    Password = "123",
                    Role = "Admin"
                };

                var user2 = new User
                {
                    Name = "Maxim",
                    Surname = "Maximov",
                    Email = "max212@gmail.com",
                    Login = "Max_12",
                    Password = "asdq13",
                    Role = "User"
                };

                var user3 = new User
                {
                    Name = "Alexey",
                    Surname = "Lobanov",
                    Email = "alex1609@mail.ru",
                    Login = "alex_lob",
                    Password = "qwerty",
                    Role = "User"
                };

                db.Users.AddRange(user1, user2, user3);

                // Заполняем данными таблицу Genres
                List<Genre> genres = new List<Genre>
                {
                    new Genre {Name = "Классическая литература"},
                    new Genre {Name = "Русская классика"},
                    new Genre {Name = "Зарубежная классика"},
                    new Genre {Name = "Исторические приключения"},
                    new Genre {Name = "Классическая проза"}
                };

                db.Genres.AddRange(genres);


                // Заполняем данными таблицу Authors
                List<Author> authors = new List<Author>
                {
                    new Author { Name = "Александр", Surname = "Дюма"},
                    new Author { Name = "Михаил", Surname = "Булгаков"},
                    new Author { Name = "Александр", Surname = "Солженицын"},
                    new Author { Name = "Стефан", Surname = "Цвейг"}
                };

                db.Authors.AddRange(authors);

                // Заполняем данными таблицу Books
                var book1 = new Book
                {
                    Name = "Граф Монте-Кристо",
                    PageCounts = 280,
                    DateRelease = new DateTime(2017, 1, 1),
                    Genre = genres[0],
                    Author = authors[0]
                };

                var book2 = new Book
                {
                    Name = "Записки юного врача",
                    PageCounts = 180,
                    DateRelease = new DateTime(2021, 1, 1),
                    Genre = genres[1],
                    Author = authors[1]
                };

                var book3 = new Book
                {
                    Name = "Раковый корпус",
                    PageCounts = 210,
                    DateRelease = new DateTime(2018, 1, 1),
                    Genre = genres[4],
                    Author = authors[2]
                };
                
                var book4 = new Book
                {
                    Name = "Нетерпение сердца",
                    PageCounts = 120,
                    DateRelease = new DateTime(2018, 1, 1),
                    Genre = genres[2],
                    Author = authors[3]
                };

                db.Books.AddRange(book1, book2, book3, book4);

                db.SaveChanges();
              
                ReadableBooksRepository rBR = new ReadableBooksRepository();
                rBR.AddBookToReadableByUserId(book1, user1.Id, db);
                rBR.AddBookToReadableByUserId(new List<Book> { book2, book3, book1 }, user3.Id, db);          
            }
        }

    }
}
