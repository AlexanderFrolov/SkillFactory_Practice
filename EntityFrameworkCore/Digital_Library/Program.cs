using System;
using System.Collections.Generic;
using System.Linq;
using Digital_Library.Models;
using Digital_Library.Repositories;

namespace Digital_Library
{
    class Program
    {   
        static void Main(string[] args)
        {
            // наполняем базу тестовыми данными
            TestData.EnterTestDataIntoDatabase();
        
            using (AppContext db = new AppContext())
            {
                //Задание финальная часть 25.5.4 *
                //С помощью полученных знаний дополните репозитории методами, которые позволят совершать следующие действия:

                BookRepository br = new BookRepository();

                //1.Получать список книг определенного жанра и вышедших между определенными годами.
                var result1 = br.GetBooksByGenreAndRangeYears("Классическая проза", 2016, 2018, db);

                //2.Получать количество книг определенного автора в библиотеке.
                var result2 = br.GetCountAuthorBooksByName("Александр", "Дюма", db);

                //3.Получать количество книг определенного жанра в библиотеке.
                var result3 = br.GetCountBooksByGenre("Зарубежная классика", db);

                //4.Получать булевый флаг о том, есть ли книга определенного автора и с определенным названием в библиотеке.
                var result4 = br.IsThereBookByAuthorAndTitle("Александр", "Дюма", "Граф Монте-Кристо", db);

                //5.Получать булевый флаг о том, есть ли определенная книга на руках у пользователя.
                var result5 = br.IsThereReadableBookByUserId(3, "Раковый корпус", db);
               
                //6.Получать количество книг на руках у пользователя.
                var result6 = br.GetCountReadableBooksByUserId(3, db);

                //7.Получение последней вышедшей книги.
                var result7 = br.GetLastBookByYear(db).Name;

                //8.Получение списка всех книг, отсортированного в алфавитном порядке по названию.
                var result8 = br.GetAllBooksByName(db, true);

                //9.Получение списка всех книг, отсортированного в порядке убывания года их выхода.
                var result9 = br.GetAllBooksByYear(db, true);
            }
        }
    }
}
